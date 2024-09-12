using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD_DotNetTest.Data;
using CRUD_DotNetTest.Model;

namespace CRUD_DotNetTest.Pages.Product
{
    public class EditModel : PageModel
    {
        private readonly CRUD_DotNetTest.Data.CRUD_DotNetTestContext _context;

        public EditModel(CRUD_DotNetTest.Data.CRUD_DotNetTestContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Produk Produk { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Produk == null)
            {
                return NotFound();
            }

            var produk =  await _context.Produk.FirstOrDefaultAsync(m => m.ID == id);
            if (produk == null)
            {
                return NotFound();
            }
            Produk = produk;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Produk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdukExists(Produk.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProdukExists(int id)
        {
          return (_context.Produk?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
