using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalonWebApi.Models;

namespace SalonWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VehiclesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Vehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
        {
            return await _context.Vehicles.ToListAsync();
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);

            if (vehicle == null)
            {
                return NotFound();
            }

            return vehicle;
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.VehicleId)
            {
                return NotFound();
            }

            _context.Entry(vehicle).State = EntityState.Modified;

            try
            {
                if(!_context.CarShowrooms.Where(c=>c.CarShowroomId==vehicle.CarShowroomId).Any())
                {
                    throw new Exception("Wrong CarShowroom Id was selected.");
                }
                vehicle.SalonName = _context.CarShowrooms.Where(c => c.CarShowroomId == vehicle.CarShowroomId).Select(c => c.Name).First();

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                // ignore 
                return Ok();
            }

            return NoContent();
        }

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            try
            {
                Vehicle newVehicle = new Vehicle();
                newVehicle.Model = vehicle.Model;
                newVehicle.Mark = vehicle.Mark;
                if (vehicle.Condition != "NEW" || vehicle.Condition != "USED")
                { newVehicle.Condition = "NEW"; }
                else
                { newVehicle.Condition = vehicle.Condition; }

                newVehicle.Price = vehicle.Price;
                newVehicle.ProductionYear = vehicle.ProductionYear;
                newVehicle.EngineCapacity = vehicle.EngineCapacity;
                newVehicle.Mileage = vehicle.Mileage;
                newVehicle.Booked = vehicle.Booked;
                newVehicle.CarShowroomId = vehicle.CarShowroomId;
                newVehicle.SalonName = _context.CarShowrooms.Where(c => c.CarShowroomId == vehicle.CarShowroomId).Select(c => c.Name).First();

                _context.Vehicles.Add(newVehicle);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetVehicle", new { id = vehicle.VehicleId }, vehicle);
            }
            catch (Exception e)
            {
                // ignore
                return Ok();
            }
            
        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicles.Any(e => e.VehicleId == id);
        }

        // GET: api/Vehicles/Csv

        [HttpGet]
        [Route("Csv")]
        public IActionResult GetCsv()
        {
            var vehicles = _context.Vehicles.ToList();

            var builder = new StringBuilder();
            builder.AppendLine("Id,Modell,Mark,Condition,Price,Year,Mileage,EngineCapacity,SalonName,Booked");

            foreach (var vehicle in vehicles)
            {
                builder.AppendLine($"{vehicle.VehicleId},{vehicle.Mark},{vehicle.Model},{vehicle.Condition},{vehicle.Price},{vehicle.ProductionYear},{vehicle.Mileage},{vehicle.EngineCapacity},{vehicle.SalonName},{vehicle.Booked}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()),"text/csv","Vehicles.csv");
        }
    }
}
