using SmartHomeDataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SmartHomeDataAccessLayer.EntityConfiguration
{
    class DeviceConfig : EntityTypeConfiguration<Device>
    {
        public DeviceConfig()
        {
            ToTable("Device").HasKey(k => k.Id);

            Property(p => p.DeviceName).HasMaxLength(100).IsUnicode().IsOptional();
            Property(p => p.DateActive).IsOptional();
            Property(p => p.DateCreated).IsOptional();
            Property(p => p.Status).IsRequired();

            HasRequired(at => at.User)
               .WithMany(u => u.Devices)
               .HasForeignKey(pk => pk.UserId)
               .WillCascadeOnDelete(false);
            HasRequired(at => at.House)
              .WithMany(h => h.Devices)
              .HasForeignKey(pk => pk.HouseId)
              .WillCascadeOnDelete(false);
            HasRequired(at => at.Category)
              .WithMany(c => c.Devices)
              .HasForeignKey(pk => pk.CategoryId)
              .WillCascadeOnDelete(false);
        }
    }
}
