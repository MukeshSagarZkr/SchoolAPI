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
    public class CompanyMasterController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public CompanyMasterController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Create Company
        [HttpPost]
        public async Task<ActionResult<CompanyMaster>> CreateCompany(CompanyMaster companyMaster)
        {
            try
            {
                companyMaster.CreatedDate = DateTime.Now;
                companyMaster.IsDeleted = false; // Default to false when creating
                _dbContext.CompanyMasters.Add(companyMaster);
                await _dbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCompanyById), new { id = companyMaster.CmpId }, companyMaster);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while creating company: {ex.Message}");
            }
        }

        // Get all companies
        [HttpGet]
        public async Task<ActionResult<IQueryable<CompanyMaster>>> GetAllCompanies()
        {
            try
            {
                var companies = await _dbContext.CompanyMasters
                    .Where(c => !c.IsDeleted)
                    .Include(c => c.CmpCity) // Assuming you want to include city and state details
                    .Include(c => c.CmpState)
                    .ToListAsync();
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while retrieving companies: {ex.Message}");
            }
        }

        // Get company by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyMaster>> GetCompanyById(int id)
        {
            try
            {
                var company = await _dbContext.CompanyMasters.FindAsync(id);
                if (company == null || company.IsDeleted)
                {
                    return NotFound($"Company with ID {id} not found or is deleted.");
                }
                return Ok(company);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while retrieving the company: {ex.Message}");
            }
        }

        // Update company
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, CompanyMaster companyMaster)
        {
            try
            {
                if (id != companyMaster.CmpId)
                {
                    return BadRequest("Company ID mismatch.");
                }

                var existingCompany = await _dbContext.CompanyMasters.FindAsync(id);
                if (existingCompany == null || existingCompany.IsDeleted)
                {
                    return NotFound($"Company with ID {id} not found or is deleted.");
                }

                existingCompany.CmpName = companyMaster.CmpName;
                existingCompany.CmpDescription = companyMaster.CmpDescription;
                existingCompany.CmpAddress = companyMaster.CmpAddress;
                existingCompany.CmpCity = companyMaster.CmpCity;
                existingCompany.CmpState = companyMaster.CmpState;
                existingCompany.CmpCountry = companyMaster.CmpCountry;
                existingCompany.CmpEmail = companyMaster.CmpEmail;
                existingCompany.CmpStateId = companyMaster.CmpStateId;
                existingCompany.CmpCityId = companyMaster.CmpCityId;
                existingCompany.CmpEstablishmentYear = companyMaster.CmpEstablishmentYear;
                existingCompany.CmpJurisdictionArea = companyMaster.CmpJurisdictionArea;
                existingCompany.IsActive = companyMaster.IsActive;
                existingCompany.ModifiedBy = companyMaster.ModifiedBy;
                existingCompany.ModifiedDate = DateTime.Now;

                _dbContext.Entry(existingCompany).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return NoContent(); // No content to return but the update was successful
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while updating company: {ex.Message}");
            }
        }

        // Soft delete company
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            try
            {
                var company = await _dbContext.CompanyMasters.FindAsync(id);
                if (company == null || company.IsDeleted)
                {
                    return NotFound($"Company with ID {id} not found or already deleted.");
                }

                company.IsDeleted = true;
                _dbContext.Entry(company).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

                return NoContent(); // Soft delete successful
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error occurred while deleting company: {ex.Message}");
            }
        }
    }
}
