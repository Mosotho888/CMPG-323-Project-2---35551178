using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _35551178_Project2.Models;
using Microsoft.AspNetCore.Authorization;

namespace _35551178_Project2.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ConnectedOfficeContext _context;

        public CategoriesController(ConnectedOfficeContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategory()
        {
            return await _context.Category.ToListAsync();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(Guid id)
        {
            var category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // GET: api/Categories/id/getAllDevicesFromSameCategory
        [HttpGet("{id}/ getAllDevicesFromSameCategory")]
        public async Task<ActionResult<IEnumerable<Device>>> GetDevice(Guid id)
        {
            var category = await _context.Device.Where(p => p.CategoryId == id).ToListAsync();
            

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // GET: api/Categories/5
        [HttpGet("{id}/ number of zones")]
        public async Task<ActionResult<IEnumerable<Zone>>> GetDevices(Guid id)
        {
            int zones = 1;
            var place = (dynamic)null;

            var category = await (from d in _context.Device
                           join c in _context.Category
                           on d.CategoryId equals c.CategoryId
                           join z in _context.Zone
                           on d.ZoneId equals z.ZoneId
                           where c.CategoryId == id
                           select new Zone()
                           {
                      
                               ZoneName = z.ZoneName,
                               
                           }).ToListAsync();
            
            foreach(var area in category)
            {
                place = area;
                break;
            }

            foreach (var area in category)
            {
                if (place != area)
                {
                    zones++;
                }
            }

            if (category == null)
            {
                return NotFound();
            }

            return Ok(zones);
        }

        // PATCH: api/Categories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchCategory(Guid id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            
            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
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

        // POST: api/Categories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.Category.Add(category);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CategoryExists(category.CategoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCategory", new { id = category.CategoryId }, category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> DeleteCategory(Guid id)
        {
            var category = await _context.Category.FindAsync(id);
            if (!CategoryExists(id))
            {
                return NotFound();
            }

            _context.Category.Remove(category);
            await _context.SaveChangesAsync();

            return category;
        }

        private bool CategoryExists(Guid id)
        {
            return _context.Category.Any(e => e.CategoryId == id);
        }
    }
}
