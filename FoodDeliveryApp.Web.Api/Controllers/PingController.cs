using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryApp.Web.Api.Controllers
{
    [Route("api/ping")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var ping = new
            {
                IsSuccess = true,
                Error = string.Empty
            };

            return new OkObjectResult(ping);
        }
    }
}
