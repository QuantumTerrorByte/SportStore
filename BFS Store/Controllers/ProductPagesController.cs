using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportStore.Models;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPagesController : ControllerBase
    {
        private readonly IProductPageDbContext _context;

        public ProductPagesController(IProductPageDbContext context)
        {
            _context = context;
        }

        // GET: api/ProductPages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductPageViewModel>>> GetProductPageViewModel()
        {
            return await _context.ProductPageViewModel.ToListAsync();
        }

        // GET: api/ProductPages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductPageViewModel>> GetProductPageViewModel(long id)
        {
            var productPageViewModel = await _context.ProductPageViewModel.FindAsync(id);

            if (productPageViewModel == null)
            {
                return NotFound();
            }

            return productPageViewModel;
        }

        // PUT: api/ProductPages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductPageViewModel(long id, ProductPageViewModel productPageViewModel)
        {
            if (id != productPageViewModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(productPageViewModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductPageViewModelExists(id))
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

        // POST: api/ProductPages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductPageViewModel>> PostProductPageViewModel(ProductPageViewModel productPageViewModel)
        {
            _context.ProductPageViewModel.Add(productPageViewModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductPageViewModel", new { id = productPageViewModel.Id }, productPageViewModel);
        }

        // DELETE: api/ProductPages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductPageViewModel(long id)
        {
            var productPageViewModel = await _context.ProductPageViewModel.FindAsync(id);
            if (productPageViewModel == null)
            {
                return NotFound();
            }

            _context.ProductPageViewModel.Remove(productPageViewModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductPageViewModelExists(long id)
        {
            return _context.ProductPageViewModel.Any(e => e.Id == id);
        }
    }
}
