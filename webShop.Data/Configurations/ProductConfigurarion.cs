using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webShopSolution.Data.Entities;

namespace webShopSolution.Data.Configurations
{
    public class ProductConfigurarion : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");//cau hinh cho bang
            builder.HasKey(x => x.Id);//cau hinh khoa chinh
            builder.Property(x => x.Price).IsRequired();//cau hinh thuoc tih
            builder.Property(x => x.OriginalPrice).IsRequired();
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);

        }
    }
}
