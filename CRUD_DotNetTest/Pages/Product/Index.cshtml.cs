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
    public class IndexModel : PageModel
    {
        private readonly CRUD_DotNetTest.Data.CRUD_DotNetTestContext _context;

        public IndexModel(CRUD_DotNetTest.Data.CRUD_DotNetTestContext context)
        {
            _context = context;
        }

        public IList<Produk> Produk { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produk != null)
            {
                Produk = await _context.Produk.ToListAsync();
            }
        }
    }
}
