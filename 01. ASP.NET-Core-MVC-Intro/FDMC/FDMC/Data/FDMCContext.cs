using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FDMC.Models
{
    public class FDMCContext : DbContext
    {
        public FDMCContext (DbContextOptions<FDMCContext> options)
            : base(options)
        {
        }

        public DbSet<FDMC.Models.Cat> Cat { get; set; }
    }
}
