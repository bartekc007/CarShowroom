using MaterialSkin;
using MaterialSkin.Controls;
using Salon.Controlers;
using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon
{
    public partial class RatingForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private RatingControler _ratingControler;

        public double rating { get; set; }
        public int salonId { get;}

        public RatingForm(int salonId)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Pink200,
                TextShade.WHITE);

            _ratingControler = new RatingControler();
            rating = 0.0;
            this.salonId = salonId;
        }

        private void FirstStar_CheckedChanged(object sender, EventArgs e)
        {
            if (FirstStar.Checked == true)
            {
                FirstStar.Checked = true;
                SecondStar.Checked = false;
                ThirdStar.Checked = false;
                FourthStar.Checked = false;
                FifthStar.Checked = false;
            }
            else
            {
                FirstStar.Checked = false;
                SecondStar.Checked = false;
                ThirdStar.Checked = false;
                FourthStar.Checked = false;
                FifthStar.Checked = false;
            }

        }
        private void SecondStar_CheckedChanged(object sender, EventArgs e)
        {
            if (SecondStar.Checked == true)
            {
                FirstStar.Checked = true;
                SecondStar.Checked = true;
                ThirdStar.Checked = false;
                FourthStar.Checked = false;
                FifthStar.Checked = false;
            }
            else
            {
                ThirdStar.Checked = false;
                FourthStar.Checked = false;
                FifthStar.Checked = false;
            }
        }
        private void ThirdStar_CheckedChanged(object sender, EventArgs e)
        {
            if (ThirdStar.Checked == true)
            {
                FirstStar.Checked = true;
                SecondStar.Checked = true;
                ThirdStar.Checked = true;
                FourthStar.Checked = false;
                FifthStar.Checked = false;
            }
            else
            {
                FourthStar.Checked = false;
                FifthStar.Checked = false;
            }
        }
        private void FourthStar_CheckedChanged(object sender, EventArgs e)
        {
            if (FourthStar.Checked == true)
            {
                FirstStar.Checked = true;
                SecondStar.Checked = true;
                ThirdStar.Checked = true;
                FourthStar.Checked = true;
                FifthStar.Checked = false;
            }
            else
            {
                FifthStar.Checked = false;
            }
        }
        private void FifthStar_CheckedChanged(object sender, EventArgs e)
        {
            if (FifthStar.Checked == true)
            {
                FirstStar.Checked = true;
                SecondStar.Checked = true;
                ThirdStar.Checked = true;
                FourthStar.Checked = true;
                FifthStar.Checked = true;
            }
        }
        private void FirstStar_Click(object sender, EventArgs e)
        {
            FirstStar_CheckedChanged(this, e);
        }
        private void SecondStar_Click(object sender, EventArgs e)
        {
            SecondStar_CheckedChanged(this, e);
        }
        private void ThirdStar_Click(object sender, EventArgs e)
        {
            ThirdStar_CheckedChanged(this, e);
        }
        private void FourthStar_Click(object sender, EventArgs e)
        {
            FourthStar_CheckedChanged(this, e);
        }
        private void FifthStar_Click(object sender, EventArgs e)
        {
            FifthStar_CheckedChanged(this, e);
        }
        private async void  SaveRatingBtn_Click(object sender, EventArgs e)
        {
            Rating ratingItem = new Rating();

            if(FifthStar.Checked == true)
            {
                this.rating = 5.0;
            }
            else if(FourthStar.Checked == true)
            {
                this.rating = 4.0;
            }
            else if (ThirdStar.Checked == true)
            {
                this.rating = 3.0;
            }
            else if(SecondStar.Checked == true)
            {
                this.rating = 2.0;
            }
            else if(FirstStar.Checked == true)
            {
                this.rating = 1.0;
            }
            else
            {
                this.rating = 0.0;
            }

            ratingItem.Description = DescriptionTextBox.Text;
            ratingItem.value = rating;
            ratingItem.date = DateTime.Now;
            ratingItem.SalonId = this.salonId;

            Task<Rating> dbItemTask = _ratingControler.GetRatingBySalonId(ratingItem.SalonId);
            var dbItem = await dbItemTask;
            if(dbItem == null) 
            { 
                _ratingControler.AddRating(ratingItem); 
            }
            else { 
                _ratingControler.UpdateRating(dbItem.RatingId,ratingItem); 
            }
            this.Close();
        }

    }
}
