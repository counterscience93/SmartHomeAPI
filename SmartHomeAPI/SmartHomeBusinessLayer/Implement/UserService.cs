using SmartHomeBusinessLayer.Define;
using SmartHomeDataAccessLayer.Entities;
using SmartHomeDataAccessLayer.Repository.Define;

namespace SmartHomeBusinessLayer.Implement
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
