namespace CoreMVC.Models.Entities
{
    public class AppUserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Prop.

        public virtual AppUser AppUser { get; set; }
    }
}
