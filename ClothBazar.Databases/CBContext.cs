using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Databases
{
   public class CBContext :  DbContext, IDisposable
   {
        public CBContext() : base("ClothBazarConnection")
            {
            }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product>  products { get; set; }
    }
}
