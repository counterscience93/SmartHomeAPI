using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDataAccessLayer.Entities
{
    public class Device : BaseEntity
    {
        public string DeviceName { get; set; }
        public int UserId { get; set; }
        public int HouseId { get; set; }
        public DateTime DateActive { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public int CategoryId { get; set; }

        public User User { get; set; }
        public House House { get; set; }
        public Category Category { get; set; }
    }
}
