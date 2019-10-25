using SmartHomeDataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SmartHomeDataAccessLayer.EntityConfiguration
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            ToTable("User").HasKey(k => k.Id);

            Property(p => p.UserName).HasMaxLength(50).IsUnicode().IsOptional();
            Property(p => p.Phone).HasMaxLength(10).IsUnicode().IsOptional();
            Property(p => p.Email).HasMaxLength(100).IsUnicode().IsOptional();
            Property(p => p.Token).HasMaxLength(50).IsUnicode().IsOptional();
            Property(p => p.Address).HasMaxLength(255).IsUnicode().IsOptional();
            Property(p => p.IsActive).IsOptional();
        }
    }
}
