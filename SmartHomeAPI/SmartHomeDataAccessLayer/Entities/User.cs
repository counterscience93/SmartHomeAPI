using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDataAccessLayer.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Phone { get; set; }
        public String Email { get; set; }
        public string Token{ get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }

        public ICollection<House> Houses { get; set; }
        public ICollection<Device> Devices { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
