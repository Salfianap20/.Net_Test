using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUD_DotNetTest.Data;
using CRUD_DotNetTest.Model;

namespace CRUD_DotNetTest.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly CRUD_DotNetTest.Data.CRUD_DotNetTestContext _context;

        public CreateModel(CRUD_DotNetTest.Data.CRUD_DotNetTestContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Produk Produk { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Produk == null || Produk == null)
            {
                return Page();
            }

            _context.Produk.Add(Produk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
