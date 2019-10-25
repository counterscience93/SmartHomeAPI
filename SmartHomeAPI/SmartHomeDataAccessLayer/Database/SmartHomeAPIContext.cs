using SmartHomeDataAccessLayer.Entities;
using SmartHomeDataAccessLayer.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDataAccessLayer.Database
{
    public class SmartHomeAPIContext : DbContext, IEntityContext
    {
        public SmartHomeAPIContext() : base("SmartHomeDB")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Category> Categories { get; set; }

        public object GetContext => this;
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configurations.Add(new UserConfig()).Add(new HouseConfig())
                .Add(new DeviceConfig()).Add(new CategoryConfig());
        }
    }
}
