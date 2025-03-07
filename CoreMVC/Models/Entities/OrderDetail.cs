namespace CoreMVC.Models.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int ProductId { get; set; }
        public int OrderID { get; set; }

        //Relational Prop.

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; } 
    }
}
