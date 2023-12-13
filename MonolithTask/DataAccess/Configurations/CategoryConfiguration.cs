using Core.Helpers.Constants;
using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Constant = Core.Helpers.Constants.Constant;

namespace DataAccess.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Deleted).HasDefaultValue<int>(0);
            builder.Property(x => x.Name).HasComment("Contains Name of Category");

            builder.HasIndex(x => new { x.Name, x.Deleted})
                   .IsUnique()
                   .HasDatabaseName("idx_Category_Name_Deleted");

            builder.HasQueryFilter(x => x.Deleted == Constant.NotDeleted);
        }
    }
}
