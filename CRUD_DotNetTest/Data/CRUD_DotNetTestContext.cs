using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_DotNetTest.Model;

namespace CRUD_DotNetTest.Data
{
    public class CRUD_DotNetTestContext : DbContext
    {
        public CRUD_DotNetTestContext (DbContextOptions<CRUD_DotNetTestContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_DotNetTest.Model.Produk> Produk { get; set; } = default!;
    }
}
