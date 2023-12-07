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
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");//cau hih cho bag
            builder.HasKey(x => x.Key);//cau hinh cho thuoc tinh
            builder.Property(x => x.Value).IsRequired(true);//cau hinh thuoc tinh
        }
    }
}
