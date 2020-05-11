using Store.Database;
using StoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
   public class CategoryServices
    {
        public void SaveCategory(Category category)
        {
            using (ShopContext db = new ShopContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            } ;
        }
        public List<Category> GetCategories()
        {
            using(ShopContext db=new ShopContext())
            {
               return db.Categories.ToList();
            }
        }
        public Category GetCategory(int ID)
        {
            using (ShopContext db = new ShopContext())
            {
                return db.Categories.Find(ID);
            }
        }
        public void UpdateCategory (Category category)
        {
            using (ShopContext db = new ShopContext())
            {
                db.Entry(category).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void DeleteCategory(int ID)
        {
            using (ShopContext db = new ShopContext())
            {
                var category = db.Categories.Find(ID);
                db.Categories.Remove(category);
                db.SaveChanges();
            }
        }

    }
}

