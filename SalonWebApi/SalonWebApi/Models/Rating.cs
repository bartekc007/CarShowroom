using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SalonWebApi.Models
{
    public class Rating
    {
        [Required]
        public int RatingId { get; set; }
        [Required]
        public int SalonId { get; set; }
        [Required]
        public DateTime date { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        [Range(0.0,5.0)]
        public double value { get; set; }
    }
}
