using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreEntities
{
   public class Category:BaseEntites
    {
     public List<Product> Products { get; set; }
     public string ImageUrl { get; set; }  
    }
}
