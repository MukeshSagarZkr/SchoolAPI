using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateMasterController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public StateMasterController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Create State
        [HttpPost]
        public async Task<ActionResult<StateMaster>> CreateState(StateMaster stateMaster)
        {
            try
            {
                stateMaster.CreatedDate = DateTime.Now;
                stateMaster.IsDeleted = false; // Default to false when creating
                _dbContext.StateMasters.Add(stateMaster);
                await _dbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(GetStateById), new { id = stateMaster.StateId }, stateMaster);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while creating state: {ex.Message}");
            }
        }

        // Get all states
        [HttpGet]
        public async Task<ActionResult<IQueryable<StateMaster>>> GetAllStates()
        {
            try
            {
                var states = await _dbContext.StateMasters.Where(s => !s.IsDeleted).ToListAsync();
                return Ok(states);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while retrieving states: {ex.Message}");
            }
        }

        // Get state by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<StateMaster>> GetStateById(int id)
        {
            try
            {
                var state = await _dbContext.StateMasters.FindAsync(id);
                if (state == null || state.IsDeleted)
                {
                    return NotFound($"State with ID {id} not found or is deleted.");
                }
                return Ok(state);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while retrieving the state: {ex.Message}");
            }
        }

        // Update state
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateState(int id, StateMaster stateMaster)
        {
            try
            {
                if (id != stateMaster.StateId)
                {
                    return BadRequest("State ID mismatch.");
                }

                var existingState = await _dbContext.StateMasters.FindAsync(id);
                if (existingState == null || existingState.IsDeleted)
                {
                    return NotFound($"State with ID {id} not found or is deleted.");
                }

                existingState.StateName = stateMaster.StateName;
                existingState.IsActive = stateMaster.IsActive;
                existingState.ModifiedBy = stateMaster.ModifiedBy;
                existingState.ModifiedDate = DateTime.Now;

                _dbContext.Entry(existingState).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return NoContent(); // No content to return but the update was successful
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while updating state: {ex.Message}");
            }
        }

        // Soft delete state
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteState(int id)
        {
            try
            {
                var state = await _dbContext.StateMasters.FindAsync(id);
                if (state == null || state.IsDeleted)
                {
                    return NotFound($"State with ID {id} not found or already deleted.");
                }

                state.IsDeleted = true;
                _dbContext.Entry(state).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

                return NoContent(); // Soft delete successful
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while deleting state: {ex.Message}");
            }
        }
    }
}
