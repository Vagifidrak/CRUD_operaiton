using Store.Database;
using StoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
   public class ProductServices
    {
        public void SaveProduct(Product product)
        {
            using (ShopContext db = new ShopContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            } ;
        }
        public List<Product> GetProducts()
        {
            using(ShopContext db=new ShopContext())
            {
               return db.Products.ToList();
            }
        }
        public Product GetProduct(int ID)
        {
            using (ShopContext db = new ShopContext())
            {
                return db.Products.Find(ID);
            }
        }
        public void UpdateProduct (Product product)
        {
            using (ShopContext db = new ShopContext())
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void DeleteProduct(int ID)
        {
            using (ShopContext db = new ShopContext())
            {
                var product = db.Products.Find(ID);
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }

    }
}

