using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ASPNET5SimpleApp.Managers;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNET5SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var heroManager = new HeroManager();
            var heros = heroManager.GetAll();

            return View(heros);
        }

    }
}
