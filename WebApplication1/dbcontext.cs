using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1
{
    public class dbcontext : DbContext
    {

            public DbSet<Product> Products { get; set; }
            public DbSet<Movie> Movies { get; set; }
        
    }



}