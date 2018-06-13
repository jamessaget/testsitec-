using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebApplication.datalayer
{
    class Class1 : DbContext
    {

        public int ProductId { get; set; } // ProductId (Primary key)
        public string ProductName { get; set; }
        public int Price { get; set; } 

    }
}
