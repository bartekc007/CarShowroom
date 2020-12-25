using MaterialSkin;
using MaterialSkin.Controls;
using Salon.Api;
using Salon.Controlers;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Salon
{
    public partial class MainForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        
        public CarShowroomContainer salonContainer { get; set; }
        public Vehicle SelectedVehicle { get; private set; }
        public Vehicle KoszykSelectedVehicle { get; set; }
        public List<Vehicle> BookedVehicles { get; set; }

        static string key;

        public VehicleControler _vehicleControler { get; set; }
        public CarShowroomControler _carShowroomControler { get; set; }
        public CarShowroomContainerControler _carShowroomContainerControler { get; set; }
        public RatingControler _ratingControler { get; set; }


        public MainForm()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Pink200,
                TextShade.WHITE);

            _vehicleControler = new VehicleControler();
            _ratingControler = new RatingControler();
            _carShowroomControler = new CarShowroomControler();
            _carShowroomContainerControler = new CarShowroomContainerControler();

            VehicleListData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            KoszykList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            Task<List<CarShowroomContainer>> salonContainerTask = _carShowroomContainerControler.GetCarShowroomContainer();
            List<CarShowroomContainer> salonCon = await salonContainerTask;
            this.salonContainer = new CarShowroomContainer();
            BookedVehicles = new List<Vehicle>();

            Task<List<CarShowroom>> salonsTask = _carShowroomControler.GetCarshowrooms();
            List<CarShowroom> salonsList = await salonsTask;

            Task<List<Vehicle>> vehiclesTask = _vehicleControler.GetVehicles();
            List<Vehicle> vehicles = await vehiclesTask;

            foreach (var salon in salonsList)
            {
                salonContainer.salons.Add(salon);
                CentersComboBox.Items.Add(salon.Name);
            }

            foreach (var vehicle in vehicles)
            {
                var salon = salonContainer.salons.Where(n => n.Name == vehicle.SalonName).FirstOrDefault();
                if (salon == null)
                    salon.CarList.Add(vehicle);
            }

            foreach (var vehicle in vehicles)
            {
                var salon = salonContainer.salons.Where(n => n.Name == vehicle.SalonName).FirstOrDefault();
                if (salon == null)
                    if(vehicle.Booked == true)
                        BookedVehicles.Add(vehicle);
            }

            CarShowroom newc = new CarShowroom("Dowolny", 20);
            newc.CarList.AddRange(vehicles);
            salonContainer.salons.Add(newc);
            CentersComboBox.Items.Add(newc.Name);


            FillVehicleListData();
            FillKoszykList();
            AvrgRatingLabel.Hide();
        }

        private async void CentersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleListData.Rows.Clear();
            key = CentersComboBox.SelectedItem.ToString();

            if(key == null)
            {
                key = "Dowolny";
            }
            else
            {
                if (key != "Dowolny")
                {
                    Task<int> salonIdTask = _carShowroomControler.GetCarShowroomId(key);
                    int salonId = await salonIdTask;

                    Task<List<Rating>> ratingsTask = _ratingControler.GetRatings(salonId);
                    var ratings = await ratingsTask;

                    if (ratings.Count >0)
                    {
                        var avrg = ratings.Average(n => n.value);

                        AvrgRatingLabel.Show();
                        AvrgRatingLabel.Text = "Średnia ocena użytkowników: " + avrg;
                    }
                    else
                    {
                        AvrgRatingLabel.Hide();
                    }
                }
                else
                {
                    AvrgRatingLabel.Hide();
                }
            }

            FillVehicleListData();
        }
        
        private async void VehicleListData_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedVehicledChb.Checked = false;
                DataGridViewRow row = this.VehicleListData.Rows[e.RowIndex];
                string vehicleIdstr = row.Cells["VehicleId"].Value.ToString();
                int vehicleId = Int32.Parse(vehicleIdstr);
                Task<Vehicle> selectedVehicleTask = _vehicleControler.GetVehicle(vehicleId);
                SelectedVehicle = await selectedVehicleTask;
                if (SelectedVehicle == null) { SelectedVehicledChb.Checked = false; }
                else { SelectedVehicledChb.Checked = true; }
            }
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Task<List<Vehicle>> vehiclesTask = _vehicleControler.GetVehicles();
            List<Vehicle> vehicleList = await vehiclesTask;

            if (string.IsNullOrEmpty(SearchTextBox.Text) == false)
            {
                VehicleListData.Rows.Clear();
                foreach (var vehicle in vehicleList)
                {
                    if (vehicle.Mark.StartsWith(SearchTextBox.Text))
                    {
                        VehicleListData.Rows.Add(vehicle.Mark,vehicle.VehicleId, vehicle.Model, vehicle.Price + "zł", vehicle.ProductionYear, vehicle.SalonName, vehicle.Booked);

                    }
                }
            }

            else if (SearchTextBox.Text == "")
            {
                VehicleListData.Rows.Clear();
                foreach (var vehicle in vehicleList)
                {
                    VehicleListData.Rows.Add(vehicle.Mark, vehicle.VehicleId, vehicle.Model, vehicle.Price + "zł", vehicle.ProductionYear, vehicle.SalonName, vehicle.Booked);

                }
            }
        }

        private async void FillVehicleListData()
        {
            if (key == null)
                key = "Dowolny";
            Task<List<Vehicle>> vehicleListTask;
            if (key == "Dowolny")
            {
                vehicleListTask = _vehicleControler.GetVehicles();
            }
            else
            {
                vehicleListTask = _vehicleControler.GetVehiclesBySalonName(key);
            }

            
            List<Vehicle> vehicleList = await vehicleListTask;

            foreach (var vehicle in vehicleList)
            {
                VehicleListData.Rows.Add(vehicle.Mark,vehicle.VehicleId, vehicle.Model, vehicle.Price + "zł", vehicle.ProductionYear, vehicle.SalonName, vehicle.Booked);
            }

        }
        private async void FillKoszykList()
        {
            Task<List<Vehicle>> BookedVehiclesTask = _vehicleControler.GetBookedVehicles();
            BookedVehicles = await BookedVehiclesTask;
            foreach (var vehicle in BookedVehicles)
            {
                KoszykList.Rows.Add(vehicle.Mark,vehicle.VehicleId, vehicle.Model, vehicle.Price + "zł", vehicle.ProductionYear, vehicle.SalonName, vehicle.Booked);
            }
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedVehicle == null)
                {
                    throw new NullReferenceException("No vehicle was selected");
                }

                foreach (var salon in salonContainer.salons)
                {
                    if (SelectedVehicle.SalonName == salon.Name)
                    {
                        salon.RemoveProduct(SelectedVehicle.Model, SelectedVehicle.Mark, SelectedVehicle.Price, SelectedVehicle.ProductionYear, SelectedVehicle.SalonName, SelectedVehicle.Booked);
                        _vehicleControler.DeleteVehicle(SelectedVehicle.VehicleId);
                    }
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            VehicleListData.Rows.Clear();
            FillVehicleListData();
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedVehicle == null)
                {
                    throw new NullReferenceException("No vehicle was selected");
                }

                foreach (var salon in salonContainer.salons)
                {
                    if (SelectedVehicle.SalonName == salon.Name)
                    {
                        //salon.RemoveProduct(SelectedVehicle.Model, SelectedVehicle.Mark, SelectedVehicle.Price, SelectedVehicle.ProductionYear, SelectedVehicle.SalonName, SelectedVehicle.Booked);
                        if(SelectedVehicle.Booked == false) 
                        { 
                            SelectedVehicle.Booked = true;
                            BookedVehicles.Add(SelectedVehicle);
                            _vehicleControler.UpdateVehicle(SelectedVehicle);
                        }
                        else 
                        { 
                            SelectedVehicle.Booked = false;
                            BookedVehicles.Remove(SelectedVehicle);
                            _vehicleControler.UpdateVehicle(SelectedVehicle);
                        }
                        salon.CarList.Add(SelectedVehicle);
                    }
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            VehicleListData.Rows.Clear();
            FillVehicleListData();
            KoszykList.Rows.Clear();
            FillKoszykList();
        }

        private async void ExpXlsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Task<List<Vehicle>> vehiclesTask = _vehicleControler.GetVehicles();
                List<Vehicle> exportData = await vehiclesTask;

                Excel.Application xlApp = new Excel.Application();

                if (xlApp == null)
                {
                    throw new Exception("Excel is not properly installed!!");
                }

                object misValue = System.Reflection.Missing.Value;
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(misValue);

                int rCnt = 2;
                int rw = exportData.Count() + 2;

                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets.Add();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets[1];

                xlWorkSheet.Cells[1, 1] = "Model";
                xlWorkSheet.Cells[1, 2] = "Mark";
                xlWorkSheet.Cells[1, 3] = "Condition";
                xlWorkSheet.Cells[1, 4] = "Price";
                xlWorkSheet.Cells[1, 5] = "Production Year";
                xlWorkSheet.Cells[1, 6] = "Mileage";
                xlWorkSheet.Cells[1, 7] = "Engine capacity";
                xlWorkSheet.Cells[1, 8] = "Salon";
                xlWorkSheet.Cells[1, 9] = "Reservation";

                foreach (var vehicle in exportData)
                {
                    xlWorkSheet.Cells[rCnt, 1] = vehicle.Model;
                    xlWorkSheet.Cells[rCnt, 2] = vehicle.Mark;
                    xlWorkSheet.Cells[rCnt, 3] = vehicle.Condition;
                    xlWorkSheet.Cells[rCnt, 4] = vehicle.Price.ToString();
                    xlWorkSheet.Cells[rCnt, 5] = vehicle.ProductionYear.ToString();
                    xlWorkSheet.Cells[rCnt, 6] = vehicle.Mileage.ToString();
                    xlWorkSheet.Cells[rCnt, 7] = vehicle.EngineCapacity.ToString();
                    xlWorkSheet.Cells[rCnt, 8] = vehicle.SalonName;
                    xlWorkSheet.Cells[rCnt, 9] = vehicle.Booked.ToString();

                    rCnt++;
                    if (rCnt >= rw)
                        break;
                }

                xlWorkSheet.Cells[++rCnt, 1] = "Booked Vehicles";
                rCnt++;
                Task<List<Vehicle>> BookedvehiclesTask = _vehicleControler.GetBookedVehicles();
                exportData = await BookedvehiclesTask;
                foreach (var vehicle in exportData)
                {
                    xlWorkSheet.Cells[rCnt, 1] = vehicle.Model;
                    xlWorkSheet.Cells[rCnt, 2] = vehicle.Mark;
                    xlWorkSheet.Cells[rCnt, 3] = vehicle.Condition;
                    xlWorkSheet.Cells[rCnt, 4] = vehicle.Price.ToString();
                    xlWorkSheet.Cells[rCnt, 5] = vehicle.ProductionYear.ToString();
                    xlWorkSheet.Cells[rCnt, 6] = vehicle.Mileage.ToString();
                    xlWorkSheet.Cells[rCnt, 7] = vehicle.EngineCapacity.ToString();
                    xlWorkSheet.Cells[rCnt, 8] = vehicle.SalonName;
                    xlWorkSheet.Cells[rCnt, 9] = vehicle.Booked.ToString();

                    rCnt++;
                }

                xlWorkBook.SaveAs("Salon.xls");
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            KoszykList.Rows.Clear();
            try
            {
                if (KoszykSelectedVehicle == null)
                {
                    throw new NullReferenceException("No vehicle was selected");
                }

                var vehicle = BookedVehicles.Where(n => n.Model == KoszykSelectedVehicle.Model &&
                        n.Mark == KoszykSelectedVehicle.Mark &&
                        n.Price == KoszykSelectedVehicle.Price &&
                        n.ProductionYear == KoszykSelectedVehicle.ProductionYear &&
                        n.SalonName == KoszykSelectedVehicle.SalonName &&
                        n.Booked == KoszykSelectedVehicle.Booked).FirstOrDefault();
                BookedVehicles.Remove(vehicle);

                foreach (var salon in salonContainer.salons)
                {
                    var vehicleItem = salon.CarList.Where(n => n.Model == KoszykSelectedVehicle.Model &&
                        n.Mark == KoszykSelectedVehicle.Mark &&
                        n.Price == KoszykSelectedVehicle.Price &&
                        n.ProductionYear == KoszykSelectedVehicle.ProductionYear &&
                        n.SalonName == KoszykSelectedVehicle.SalonName &&
                        n.Booked == KoszykSelectedVehicle.Booked).FirstOrDefault();
                    if (vehicleItem != null)
                    {
                        vehicleItem.Booked = false;
                        _vehicleControler.UpdateVehicle(vehicleItem);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("{0}", ex.Message);
            }
            FillKoszykList();
            VehicleListData.Rows.Clear();
            FillVehicleListData();
        }

        private async void KoszykList_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.KoszykList.Rows[e.RowIndex];
                
                string vehicleIdstr = row.Cells["KoszykVehicleId"].Value.ToString();
                int vehicleId = Int32.Parse(vehicleIdstr);

                Task<Vehicle> selectedVehicleTask = _vehicleControler.GetVehicle(vehicleId); 
                KoszykSelectedVehicle = await selectedVehicleTask;

                if (KoszykSelectedVehicle == null) { KoszykSelectedVehicleChb.Checked = false; }
                else { KoszykSelectedVehicleChb.Checked = true; }

            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            KoszykList.Rows.Clear();
            FillKoszykList();
        }

        private async void RatingBtn_Click(object sender, EventArgs e)
        {
            if (key == null)
                key = "Dowolny";

            if(key=="Dowolny")
            {
                MessageBox.Show("You have to choose salon first!");
            }
            else
            {
                Task<int> salonIdTask = _carShowroomControler.GetCarShowroomId(key);
                int salonId = await salonIdTask;
                RatingForm ratingForm = new RatingForm(salonId);
                ratingForm.Show();
            }
            

        }

        private void xlsLinkLabel_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {

                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            xlsLinkLabel.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://localhost:44315/api/Vehicles/Csv");
        }
    }
}
