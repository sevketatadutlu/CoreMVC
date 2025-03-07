namespace CoreMVC.Models.Entities
{
    public class AppUser : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }

        //Relational Prop.

        public virtual AppUserProfile AppUserProfile { get; set; }
        public virtual ICollection<Order> MOrders { get; set; }
    }
}
