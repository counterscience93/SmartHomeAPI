using SmartHomeBusinessLayer.Define;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartHomeAPI.Controllers
{
    public class HouseController : ApiController
    {
        private readonly IHouseService houseService;
        public HouseController(IHouseService houseService)
        {
            this.houseService = houseService;
        }
    }
}
