using CoreMVC.Models.ContextClasses;
using CoreMVC.Models.Entities;
using CoreMVC.Models.PageVms.Products;

using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class ProductController : Controller
    {
        readonly MyContext _context;

        public ProductController(MyContext context)
        {
            _context = context;
        }

        public IActionResult CreateProduct()
        {
            CreateProductPageVm createProductPageVm = new CreateProductPageVm()
            { 
              Categories= _context.Categories.ToList()
            };
            return View(createProductPageVm);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges(); 
            return RedirectToAction("ListProductAndCategory","ProductAndCategory");
        }
        public IActionResult UpdateProduct(int id)
        {     
            Product product = _context.Products.Find(id);

            UpdateProductPageVm p = new UpdateProductPageVm()
            {
                Product = product,
                Categories = _context.Categories.ToList()
            };

            return View(p);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            Product p = _context.Products.Find(product.Id);

            p.ProductName = product.ProductName;
            p.UnitPrice = product.UnitPrice;
            p.CategoryId = product.CategoryId;
            p.UpdatedDate = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("ListProductAndCategory", "ProductAndCategory");

        }
        public IActionResult DeleteProduct(int id)
        {
            Product p = _context.Products.Find(id);
            _context.Products.Remove(p);
            _context.SaveChanges();
            return RedirectToAction("ListProductAndCategory", "ProductAndCategory");
        }
    }
}
