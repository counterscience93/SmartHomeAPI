using SmartHomeBusinessLayer.Define;
using SmartHomeDataAccessLayer.Entities;
using SmartHomeDataAccessLayer.Repository.Define;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeBusinessLayer.Implement
{
    public class HouseService : BaseService<House>, IHouseService
    {
        public HouseService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
