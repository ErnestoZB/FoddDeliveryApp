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
    public class MenuController : ControllerBase
    {
        private readonly IBaseManager<Menu> _manager;

        public MenuController(IBaseManager<Menu> manager)
        {
            _manager = manager;
        }

        [Route("api/menus")]
        [HttpGet]
        public IEnumerable<Menu> Get()
        {
            return _manager.GetAll();
        }

        [Route("api/menus/{id}")]
        public Menu Get(int id)
        {
            return _manager.GetById(id);
        }
    }
}
