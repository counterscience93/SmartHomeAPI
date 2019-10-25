using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDataAccessLayer.Entities
{
    public class Category :BaseEntity
    {
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public DateTime TimeUpDate { get; set; }
        public int UserUpdate { get; set; }

        public ICollection<Device> Devices { get; set; }
        public User User { get; set; }

    }
}
