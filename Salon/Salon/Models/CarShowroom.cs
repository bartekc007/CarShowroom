using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class CarShowroom
    {
        public CarShowroom()
        {
            this.CarList = new List<Vehicle>();
        }
        public CarShowroom(string name, int maxCapacity)
        {
            this.Name = name;
            this.CarList = new List<Vehicle>();
            this.MaxCapacity = maxCapacity;
        }
        public int CarShowroomId { get; set; }
        public string Name { get; set; }
        public int MaxCapacity { get; set; }
        public List<Vehicle> CarList { get; set; }

        public int CarShowroomContainerId { get; set; }
        //public CarShowroomContainer CarShowroomContainer { get; set; }
        //public List<Rating> Ratings { get; set; }

        public void RemoveProduct(string model, string mark, double price, int year, string salonName, bool reservation)
        {
            var MarkItems = this.CarList.Where(n => n.Mark == mark);
            var ModelItems = MarkItems.Where(n => n.Model == model);
            var PriceItem = ModelItems.Where(n => n.Price == price);
            var YearItem = PriceItem.Where(n => n.ProductionYear == year);
            var SalonItem = YearItem.Where(n => n.SalonName == salonName);
            var reservationItem = SalonItem.Where(n => n.Booked == reservation);
            Vehicle item = reservationItem.First();

            if (item != null)
            {
                this.CarList.Remove(item);
            }
        }

    }

}
