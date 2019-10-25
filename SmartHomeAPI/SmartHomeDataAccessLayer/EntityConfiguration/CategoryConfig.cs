using SmartHomeDataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDataAccessLayer.EntityConfiguration
{
    public class CategoryConfig : EntityTypeConfiguration<Category>
    {
        public CategoryConfig()
        {
            ToTable("Category").HasKey(k => k.Id);

            Property(p => p.CategoryName).HasMaxLength(50).IsUnicode().IsRequired();
            Property(p => p.IsActive).IsRequired();
            Property(p => p.TimeUpDate).IsOptional();

            HasRequired(at => at.User)
               .WithMany(u => u.Categories)
               .HasForeignKey(pk => pk.UserUpdate)
               .WillCascadeOnDelete(false);
        }
    }
}
