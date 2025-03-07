namespace CoreMVC.Models.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Prop.

        public virtual ICollection<Product> Products { get; set; }
    }
}
