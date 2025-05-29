using DataAccess.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Configurations
{
    public class CarEntityConfigs : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Cars");

            builder
                .HasOne(x => x.Category).WithMany(x => x.Cars).HasForeignKey(x => x.CategoryId);
            builder
                .Property(x => x.CategoryId).HasDefaultValue((int)Categories.Other);
        }
    }
}
