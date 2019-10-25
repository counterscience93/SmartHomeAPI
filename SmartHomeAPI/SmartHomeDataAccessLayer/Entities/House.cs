using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDataAccessLayer.Entities
{
    public class House : BaseEntity
    {
        public string HouseName { get; set; }
        public int UserId { get; set; }
        public DateTime DateActive { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }

        public User User { get; set; }
        public ICollection<Device> Devices { get; set; }
    }
}
