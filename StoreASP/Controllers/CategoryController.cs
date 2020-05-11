using Store.Services;
using StoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreASP.Controllers
{
    public class CategoryController : Controller
    {
        CategoryServices categoryServices = new CategoryServices();
        public ActionResult Index()
        {
            var categories = categoryServices.GetCategories();
            return View(categories);
        }
        // GET: Category
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryServices.SaveCategory(category);
            return View();
        }
        public ActionResult Edit(int ID)
        {
            var category = categoryServices.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryServices.UpdateCategory(category);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int ID)
        {
            var category = categoryServices.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            categoryServices.DeleteCategory(category.ID);
            return RedirectToAction("Index");
        }
    }
}