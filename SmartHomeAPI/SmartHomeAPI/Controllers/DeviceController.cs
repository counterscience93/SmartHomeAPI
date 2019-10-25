using SmartHomeBusinessLayer.Define;
using System.Web.Http;

namespace SmartHomeAPI.Controllers
{
    public class DeviceController : ApiController
    {
        private readonly IDeviceService deviceService;
        public DeviceController(IDeviceService deviceService)
        {
            this.deviceService = deviceService;
        }
    }
}
