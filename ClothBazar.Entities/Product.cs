using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
   public class Product : BaseEntity
    {
        // BaseEnity Inheritance kar raha apni porperty idr 

       
        public Decimal Price { get; set; }

        public Category Category { get; set; }

    }
}
