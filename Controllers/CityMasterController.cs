using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityMasterController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public CityMasterController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Create City
        [HttpPost]
        public async Task<ActionResult<CityMaster>> CreateCity(CityMaster cityMaster)
        {
            try
            {
                cityMaster.CreatedDate = DateTime.Now;
                cityMaster.IsDeleted = false; // Default to false when creating
                _dbContext.CityMasters.Add(cityMaster);
                await _dbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCityById), new { id = cityMaster.CityId }, cityMaster);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while creating city: {ex.Message}");
            }
        }

        // Get all cities
        [HttpGet]
        public async Task<ActionResult<IQueryable<CityMaster>>> GetAllCities()
        {
            try
            {
                var cities = await _dbContext.CityMasters
                    .Where(c => !c.IsDeleted)
                    .Include(c => c.CityStateId) // Assuming you want to include state details
                    .ToListAsync();
                return Ok(cities);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while retrieving cities: {ex.Message}");
            }
        }

        // Get city by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<CityMaster>> GetCityById(int id)
        {
            try
            {
                var city = await _dbContext.CityMasters.FindAsync(id);
                if (city == null || city.IsDeleted)
                {
                    return NotFound($"City with ID {id} not found or is deleted.");
                }
                return Ok(city);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while retrieving the city: {ex.Message}");
            }
        }

        // Update city
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCity(int id, CityMaster cityMaster)
        {
            try
            {
                if (id != cityMaster.CityId)
                {
                    return BadRequest("City ID mismatch.");
                }

                var existingCity = await _dbContext.CityMasters.FindAsync(id);
                if (existingCity == null || existingCity.IsDeleted)
                {
                    return NotFound($"City with ID {id} not found or is deleted.");
                }

                existingCity.CityName = cityMaster.CityName;
                existingCity.CityStateId = cityMaster.CityStateId;
                existingCity.IsActive = cityMaster.IsActive;
                existingCity.ModifiedBy = cityMaster.ModifiedBy;
                existingCity.ModifiedDate = DateTime.Now;

                _dbContext.Entry(existingCity).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return NoContent(); // No content to return but the update was successful
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while updating city: {ex.Message}");
            }
        }

        // Soft delete city
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            try
            {
                var city = await _dbContext.CityMasters.FindAsync(id);
                if (city == null || city.IsDeleted)
                {
                    return NotFound($"City with ID {id} not found or already deleted.");
                }

                city.IsDeleted = true;
                _dbContext.Entry(city).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

                return NoContent(); // Soft delete successful
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while deleting city: {ex.Message}");
            }
        }
    }
}
