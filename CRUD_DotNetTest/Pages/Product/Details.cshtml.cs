using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_DotNetTest.Data;
using CRUD_DotNetTest.Model;

namespace CRUD_DotNetTest.Pages.Product
{
    public class DetailsModel : PageModel
    {
        private readonly CRUD_DotNetTest.Data.CRUD_DotNetTestContext _context;

        public DetailsModel(CRUD_DotNetTest.Data.CRUD_DotNetTestContext context)
        {
            _context = context;
        }

      public Produk Produk { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Produk == null)
            {
                return NotFound();
            }

            var produk = await _context.Produk.FirstOrDefaultAsync(m => m.ID == id);
            if (produk == null)
            {
                return NotFound();
            }
            else 
            {
                Produk = produk;
            }
            return Page();
        }
    }
}
