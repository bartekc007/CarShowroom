using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Data.Entity;

namespace SalonWebApi.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<CarShowroom> CarShowrooms { get; set; }
        public DbSet<CarShowroomContainer> CarShowroomContainers { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
