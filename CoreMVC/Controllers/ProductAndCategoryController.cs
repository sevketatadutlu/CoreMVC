using CoreMVC.Models.ContextClasses;
using CoreMVC.Models.Entities;
using CoreMVC.Models.PageVms;
using CoreMVC.Models.PageVms.Categories;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class ProductAndCategoryController : Controller
    {
        readonly MyContext _context;

        public ProductAndCategoryController(MyContext context)
        {
            _context = context;
        }

        public IActionResult ListProductAndCategory()
        {

            ListProductAndCategoryPageVm listVm = new ListProductAndCategoryPageVm()
            {
                Products = _context.Products.ToList(),
                Categories = _context.Categories.ToList(),
            };

            return View(listVm);
        }

        


    }
}
