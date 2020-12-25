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
    public class CarShowroomContainersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CarShowroomContainersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CarShowroomContainers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarShowroomContainer>>> GetCarShowroomContainers()
        {
            return await _context.CarShowroomContainers.ToListAsync();
        }

        // GET: api/CarShowroomContainers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarShowroomContainer>> GetCarShowroomContainer(int id)
        {
            var carShowroomContainer = await _context.CarShowroomContainers.FindAsync(id);

            if (carShowroomContainer == null)
            {
                return NotFound();
            }

            return carShowroomContainer;
        }

        // PUT: api/CarShowroomContainers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarShowroomContainer(int id, CarShowroomContainer carShowroomContainer)
        {
            if (id != carShowroomContainer.CarShowroomContainerId)
            {
                return BadRequest();
            }

            _context.Entry(carShowroomContainer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarShowroomContainerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CarShowroomContainers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarShowroomContainer>> PostCarShowroomContainer(CarShowroomContainer carShowroomContainer)
        {
            try
            {
                CarShowroomContainer newCarShowroomContainer = new CarShowroomContainer();
                //newCarShowroomContainer.salons = new List<CarShowroom>();

                _context.CarShowroomContainers.Add(carShowroomContainer);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCarShowroomContainer", new { id = carShowroomContainer.CarShowroomContainerId }, carShowroomContainer);
            }
            catch (Exception)
            {
                // ignore
                return Ok();
            }
            
        }

        // DELETE: api/CarShowroomContainers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarShowroomContainer(int id)
        {
            List<CarShowroom> carShowrooms = await _context.CarShowrooms.Where(c => c.CarShowroomContainerId == id).ToListAsync();
            foreach (var carShowroom in carShowrooms)
            {
                _context.CarShowrooms.Remove(carShowroom);
            }
            var carShowroomContainer = await _context.CarShowroomContainers.FindAsync(id);
            if (carShowroomContainer == null)
            {
                return NotFound();
            }

            _context.CarShowroomContainers.Remove(carShowroomContainer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarShowroomContainerExists(int id)
        {
            return _context.CarShowroomContainers.Any(e => e.CarShowroomContainerId == id);
        }
    }
}
