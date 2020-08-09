using System.Collections.Generic;
using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Managers.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodDeliveryApp.Web.Api.Controllers
{
    [ApiController]
    public class FoodCategoryController : ControllerBase
    {
        private readonly IBaseManager<FoodCategory> _manager;

        public FoodCategoryController(IBaseManager<FoodCategory> manager)
        {
            _manager = manager;
        }

        [Route("api/foodcategories")]
        [HttpGet]
        public IEnumerable<FoodCategory> Get()
        {
            return _manager.GetAll();
        }
    }
}