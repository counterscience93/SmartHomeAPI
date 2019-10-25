using SmartHomeBusinessLayer.Define;
using System;
using System.Web.Http;

namespace SmartHomeAPI.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        [Route("getall")]
        public IHttpActionResult GetAllUsers()
        {
            try
            {
                var result = userService.GetAll();
                return Ok(result);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
