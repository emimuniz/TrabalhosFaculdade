using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCTP.Models
{ 
    public class VooDbContext: DbContext
    {
        public DbSet<Voo> Voos { get; set; }

    }
}
