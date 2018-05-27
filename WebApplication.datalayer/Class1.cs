using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication.datalayer
{
    public class Class1 : DbContext
    {
        public DbSet<Product> Products {get; set;}
        public DbSet<Movie> Movies { get; set; }
    }
}
