using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonWebApi.Models
{
    public enum ItemCondition { NEW,USED}
    public class Vehicle  
    {

        [Required]
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public string Mark { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Condition { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int ProductionYear { get; set; }
        [Required]
        public double Mileage { get; set; }
        [Required]
        public double EngineCapacity { get; set; }
        [Required]
        public string SalonName { get; set; }
        [Required]
        public bool Booked { get; set; }

        public int CarShowroomId { get; set; }
        //public CarShowroom CarShowroom { get; set; }

        public Vehicle(string mark, string model, string Condition, double price, int year, double mileage, double engineCapacity, string SalonName, CarShowroom cr)
        {
            this.Mark = mark;
            this.Model = model;
            this.Condition = Condition;
            this.Price = price;
            this.ProductionYear = year;
            this.Mileage = mileage;
            this.EngineCapacity = engineCapacity;
            this.SalonName = SalonName;
            this.Booked = false;
            //this.CarShowroom = cr;
        }
        public Vehicle(string mark, string model, string Condition, double price, int year, double mileage, double engineCapacity, string SalonName)
        {
            this.Mark = mark;
            this.Model = model;
            this.Condition = Condition;
            this.Price = price;
            this.ProductionYear = year;
            this.Mileage = mileage;
            this.EngineCapacity = engineCapacity;
            this.SalonName = SalonName;
            this.Booked = false;
        }
        public Vehicle()
        {

        }
    }
}
