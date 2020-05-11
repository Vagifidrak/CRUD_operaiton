using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreEntities
{
   public class Product:BaseEntites
    {
      
        public float Price { get; set; }
        public Category Category { get; set; }
    }
}
