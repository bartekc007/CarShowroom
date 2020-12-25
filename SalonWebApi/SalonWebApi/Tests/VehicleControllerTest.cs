using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalonWebApi.Controllers;
using SalonWebApi.Models;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalonWebApi.Tests
{
    [TestFixture]
    public class VehicleControllerTest
    {
        VehiclesController controller;

        [SetUp]
        public void SetUp(ApplicationDbContext context)
        {
            controller = new VehiclesController(context);
        }

        [Test]
        public async Task IsPrime_InputIs1_ReturnFalseAsync()
        {
            Task.Run(async () =>
            {
                // Actual test code here.
                var VehiclesResult = await controller.GetVehicles();
                List<Vehicle> Vehicles = VehiclesResult.Value.ToList();
                Assert.AreEqual(57, Vehicles.Count());

            }).GetAwaiter().GetResult();
            
        }
    }
}
