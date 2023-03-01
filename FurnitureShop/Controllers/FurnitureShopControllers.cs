using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FurnitureShop.Models;

namespace FurnitureShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductLinesController : ControllerBase
    {
        private readonly FurnitureShopContext _context;

        public ProductLinesController(FurnitureShopContext context)
        {
            _context = context;
        }

        // GET: api/ProductLines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductLine>>> GetProductLines()
        {
          if (_context.ProductLines == null)
          {
              return NotFound();
          }
            return await _context.ProductLines.ToListAsync();
        }

        // GET: api/ProductLines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductLine>> GetProductLine(int id)
        {
          if (_context.ProductLines == null)
          {
              return NotFound();
          }
            var productLine = await _context.ProductLines.FindAsync(id);

            if (productLine == null)
            {
                return NotFound();
            }

            return productLine;
        }

        // PUT: api/ProductLines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductLine(int id, ProductLine productLine)
        {
            if (id != productLine.ProductLineId)
            {
                return BadRequest();
            }

            _context.Entry(productLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductLineExists(id))
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

        // POST: api/ProductLines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductLine>> PostProductLine(ProductLine productLine)
        {
          if (_context.ProductLines == null)
          {
              return Problem("Entity set 'FurnitureShopContext.ProductLines'  is null.");
          }
            _context.ProductLines.Add(productLine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductLine", new { id = productLine.ProductLineId }, productLine);
        }

        // DELETE: api/ProductLines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductLine(int id)
        {
            if (_context.ProductLines == null)
            {
                return NotFound();
            }
            var productLine = await _context.ProductLines.FindAsync(id);
            if (productLine == null)
            {
                return NotFound();
            }

            _context.ProductLines.Remove(productLine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductLineExists(int id)
        {
            return (_context.ProductLines?.Any(e => e.ProductLineId == id)).GetValueOrDefault();
        }
    }
}
