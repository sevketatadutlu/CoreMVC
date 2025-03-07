using CoreMVC.Models.Entities;


namespace CoreMVC.Models.PageVms.Products
{
    public class UpdateProductPageVm
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
