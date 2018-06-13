using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication.datalayer
{
 
    public class dbgeneration : DbContext
    {
        public DbSet<Product> Products {get; set;}
        public DbSet<Movie> Movies { get; set; }
    }
}

 