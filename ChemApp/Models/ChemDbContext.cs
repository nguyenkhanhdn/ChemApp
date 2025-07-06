using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChemApp.Models
{
    public class ChemDbContext:DbContext
    {
        public ChemDbContext() : base("ChemConnection")
        {
        }
        public DbSet<Chem> Chems { get; set; }
    
    }
}