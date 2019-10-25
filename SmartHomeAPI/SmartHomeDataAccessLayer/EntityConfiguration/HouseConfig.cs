using SmartHomeDataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SmartHomeDataAccessLayer.EntityConfiguration
{
    public class HouseConfig : EntityTypeConfiguration<House>
    {
        public HouseConfig()
        {
            ToTable("House").HasKey(k => k.Id);

            Property(p => p.HouseName).HasMaxLength(100).IsUnicode().IsOptional();
            Property(p => p.DateActive).IsOptional();
            Property(p => p.DateCreated).IsOptional();
            Property(p => p.Status).IsRequired();

            HasRequired(at => at.User)
                .WithMany(u => u.Houses)
                .HasForeignKey(pk => pk.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
