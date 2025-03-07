using CoreMVC.Models.Entities;


namespace CoreMVC.Models.PageVms
{
    public class ListProductAndCategoryPageVm
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
