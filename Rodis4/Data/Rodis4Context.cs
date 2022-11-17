using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rodis4.WINSLEE;

namespace Rodis4.Data
{
    public class Rodis4Context : DbContext
    {
        public Rodis4Context (DbContextOptions<Rodis4Context> options)
            : base(options)
        {
        }

        public DbSet<Rodis4.WINSLEE.winslee> winslee { get; set; } = default!;
    }
}
