using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2_PILCO_JOSEE.Models;
using Microsoft.EntityFrameworkCore;
namespace T2_PILCO_JOSEE.Datos
{

   
    
      public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Distribuidor> Distribuidor { get; set; }
    }
}
