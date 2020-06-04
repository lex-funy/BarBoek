using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BarboekMVC.Models;
using BarboekMVC.Interface;

namespace BarboekMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(ClubModel club)
        {
            iClubRetrieveContext context = HttpContext.RequestServices.GetService(typeof(BarboekMVC.DAL.MySQL.ClubMySQLContext)) as iClubRetrieveContext;
            iUserRetrieveContext ucontext = HttpContext.RequestServices.GetService(typeof(BarboekMVC.DAL.MySQL.UserMySQLContext)) as iUserRetrieveContext;
            UserModel user = new UserModel();
            user.UEmail = club.ClubNumber;
            user.Password = club.Postcode;
            bool check = context.Inloggen(club);
            bool ucheck = ucontext.Inloggen(user);
            if (check)
            {
                return View("~/Views/User/Confirm.cshtml");
            }
            else
            {
                if (ucheck)
                {
                    return View("Fout");
                }
                else
                {
                    ModelState.AddModelError("Postcode", "Password incorrect.");
                    return View("Index");
                }               
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
