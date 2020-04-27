using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingPizza.Server
{
    [Route("pizzas")]
    [ApiController]
    public class PizzasController : Controller
    {
        private readonly PizzaStoreContext _db;

        public PizzasController(PizzaStoreContext db)
        {
            _db = db;
        }
    }
}
