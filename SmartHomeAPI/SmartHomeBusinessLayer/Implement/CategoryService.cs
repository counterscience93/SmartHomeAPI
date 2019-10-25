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
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}
