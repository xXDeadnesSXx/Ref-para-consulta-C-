using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DCP_OMNI.Models;

namespace DCP_OMNI.Data
{
    public class DCP_OMNIContext : DbContext
    {
        public DCP_OMNIContext (DbContextOptions<DCP_OMNIContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<DCP_OMNI.Models.Material> Material { get; set; }
    }
}
