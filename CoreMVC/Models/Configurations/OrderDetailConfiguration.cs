using CoreMVC.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVC.Models.Configurations
{
    public class OrderDetailConfiguration : BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            //Many to many relationship (EF Core)
            builder.Ignore(x=>x.Id);
            builder.HasKey(x=> new {

                x.OrderID,
                x.ProductId
            
            });
        }
    }
}
