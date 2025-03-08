using CoreMVC.Models.ContextClasses;
using CoreMVC.Models.Entities;
using CoreMVC.Models.PageVms.Categories;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class CategoryController : Controller
    {
        readonly MyContext _context;

        public CategoryController(MyContext context)
        {
            _context = context;
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            category.CreatedDate = DateTime.Now;
            category.Status = Models.Enums.DataStatus.Inserted;
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("ListProductAndCategory","ProductAndCategory");
        }

        public IActionResult UpdateCategory(int id)
        {
            Category category = _context.Categories.Find(id);
            UpdateCategoryPageVm updateCategoryVm = new UpdateCategoryPageVm()
            {
                Category = category
            };
            return View(updateCategoryVm);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            Category c = _context.Categories.Find(category.Id);
            c.CategoryName = category.CategoryName;
            c.Description = category.Description;
            c.UpdatedDate = DateTime.Now;
            c.Status = Models.Enums.DataStatus.Updated;
            _context.SaveChanges();
            return RedirectToAction("ListProductAndCategory", "ProductAndCategory");
        }

        public IActionResult DeleteCategory(int id)
        {
            Category c = _context.Categories.Find(id);
            _context.Categories.Remove(c);
            _context.SaveChanges();
            return RedirectToAction("ListProductAndCategory", "ProductAndCategory");
        }
    }
}
