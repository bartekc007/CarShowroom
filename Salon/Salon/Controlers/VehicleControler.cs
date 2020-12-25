using Salon.Api;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Controlers
{
    public class VehicleControler
    {
        public VehicleControler() { }

        public async void AddVehicle(Vehicle vehicle)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync("api/Vehicles", vehicle))
            {
                if (response.IsSuccessStatusCode) { }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<Vehicle> GetVehicle(int VehicleId)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/Vehicles/" + VehicleId))
            {
                if (response.IsSuccessStatusCode)
                {
                    Vehicle vehicle = await response.Content.ReadAsAsync<Vehicle>();
                    return vehicle;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<List<Vehicle>> GetVehicles()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/Vehicles"))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<Vehicle> vehicleList = await response.Content.ReadAsAsync<List<Vehicle>>();
                    return vehicleList;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<List<Vehicle>> GetVehiclesBySalonName(string salonName)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/Vehicles"))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<Vehicle> vehicleList = await response.Content.ReadAsAsync<List<Vehicle>>();
                    return vehicleList.Where(v=>v.SalonName == salonName).ToList();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<List<Vehicle>> GetBookedVehicles()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("api/Vehicles"))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<Vehicle> vehicleList = await response.Content.ReadAsAsync<List<Vehicle>>();
                    return vehicleList.Where(v=>v.Booked == true).ToList();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async void UpdateVehicle(Vehicle vehicle)
        {
            try
            {
                Task<Vehicle> newVehicleTask = GetVehicle(vehicle.VehicleId);
                Vehicle newVehicle = await newVehicleTask;

                if (newVehicle == null)
                    throw new EntryPointNotFoundException("Vehiclee Not found in database");

                newVehicle.Mark = vehicle.Mark;
                newVehicle.Model = vehicle.Model;
                newVehicle.Price = vehicle.Price;
                newVehicle.ProductionYear = vehicle.ProductionYear;
                newVehicle.Condition = vehicle.Condition;
                newVehicle.Mileage = vehicle.Mileage;
                newVehicle.EngineCapacity = vehicle.EngineCapacity;
                newVehicle.SalonName = vehicle.SalonName;
                newVehicle.Booked = vehicle.Booked;

                using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsJsonAsync("api/Vehicles/" + vehicle.VehicleId,newVehicle))
                {
                    if (response.IsSuccessStatusCode) { }
                    else { throw new Exception(response.ReasonPhrase); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void DeleteVehicle(int VehicleId)
        {
            Task<Vehicle> vehicleTask = GetVehicle(VehicleId);
            Vehicle vehicle = await vehicleTask;
            if (vehicle != null)
            {
                using(HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync("api/Vehicle/" +VehicleId))
                {
                    if (response.IsSuccessStatusCode) { }
                    else { throw new Exception(response.ReasonPhrase); }
                }
            }
            
        }



        
    }
}
