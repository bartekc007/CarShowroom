using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalonWebApi.Models;

namespace SalonWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarShowroomsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CarShowroomsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CarShowrooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarShowroom>>> GetCarShowrooms()
        {
            return await _context.CarShowrooms.ToListAsync();
        }

        // GET: api/CarShowrooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarShowroom>> GetCarShowroom(int id)
        {
            var carShowroom = await _context.CarShowrooms.FindAsync(id);

            if (carShowroom == null)
            {
                return NotFound();
            }

            return carShowroom;
        }

        // PUT: api/CarShowrooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarShowroom(int id, CarShowroom carShowroom)
        {
            if (id != carShowroom.CarShowroomId)
            {
                return BadRequest();
            }

            _context.Entry(carShowroom).State = EntityState.Modified;

            try
            {
                if (!_context.CarShowroomContainers.Where(c => c.CarShowroomContainerId == carShowroom.CarShowroomContainerId).Any())
                {
                    throw new Exception("Wrong CarShowroomContainer Id was selected.");
                }
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarShowroomExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                // ignore 
                return Ok();
            }

            return NoContent();
        }

        // POST: api/CarShowrooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarShowroom>> PostCarShowroom(CarShowroom carShowroom)
        {
            try
            {
                CarShowroom newCarShowroom = new CarShowroom();

                if (!_context.CarShowroomContainers.Where(c => c.CarShowroomContainerId == carShowroom.CarShowroomContainerId).Any())
                {
                    throw new Exception("Wrong CarShowroomContainer Id was selected.");
                }
                else
                {
                    newCarShowroom.CarShowroomContainerId = carShowroom.CarShowroomContainerId;
                }

                newCarShowroom.Name = carShowroom.Name;
                newCarShowroom.MaxCapacity = carShowroom.MaxCapacity;
                //newCarShowroom.CarList = new List<Vehicle>();

                _context.CarShowrooms.Add(newCarShowroom);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCarShowroom", new { id = carShowroom.CarShowroomId }, carShowroom);
            }
            catch (Exception e)
            {
                // ignore
                return Ok();
            }
            
        }

        // DELETE: api/CarShowrooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarShowroom(int id)
        {
            List<Vehicle> vehicles = await _context.Vehicles.Where(v => v.CarShowroomId == id).ToListAsync();
            foreach (var vehicle in vehicles)
            {
                _context.Vehicles.Remove(vehicle);
            }
            List<Rating> ratings = await _context.Ratings.Where(r => r.SalonId == id).ToListAsync();
            foreach (var rating in ratings)
            {
                _context.Ratings.Remove(rating);
            }
            var carShowroom = await _context.CarShowrooms.FindAsync(id);
            if (carShowroom == null)
            {
                return NotFound();
            }

            _context.CarShowrooms.Remove(carShowroom);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarShowroomExists(int id)
        {
            return _context.CarShowrooms.Any(e => e.CarShowroomId == id);
        }

        // GET: api/CarShowrooms/5/rating
        [HttpGet("{id}/rating")]
        public async Task<ActionResult<double>> GetCarShowroomRating(int id)
        {
            var ratings = await _context.Ratings.Where(r=>r.SalonId == id).ToListAsync();

            if (ratings == null)
            {
                return 0.0;
            }
            double avrgRating = ratings.Average(r => r.value);

            return avrgRating;
        }
        // GET: api/CarShowrooms/5/rating
        [HttpGet("{id}/products")]
        public async Task<List<Vehicle>> GetCarShowroomVehicles(int id)
        {
            
            return  await _context.Vehicles.Where(r => r.CarShowroomId == id).ToListAsync();
        }

        // GET: api/CarShowrooms/5/rating
        [HttpGet("{id}/fill")]
        public async Task<double> GetCarShowroomFulfilment(int id)
        {
            double maxcapacity = await _context.CarShowrooms.Where(c => c.CarShowroomId == id).Select(c => c.MaxCapacity).FirstOrDefaultAsync();
            double vehicles = _context.Vehicles.Where(v => v.CarShowroomId == id).Count();

            return (vehicles / maxcapacity * 100);
        }


    }
}
