using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Managers.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodDeliveryApp.Web.Api.Controllers
{
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IBaseManager<Restaurant> _manager;

        public RestaurantController(IBaseManager<Restaurant> manager)
        {
            _manager = manager;
        }

        [Route("api/restaurants")]
        [HttpGet]
        public IEnumerable<Restaurant> Get()
        {
            return _manager.GetAll();
        }

        [Route("api/restaurant/{id}")]
        [HttpGet]
        public Restaurant Get(int id)
        {
            return _manager.GetById(id);
        }
    }
}
