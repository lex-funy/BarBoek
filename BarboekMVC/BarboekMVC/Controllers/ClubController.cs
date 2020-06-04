using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarboekMVC.Interface;
using BarboekMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarboekMVC.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            iClubRetrieveContext context = HttpContext.RequestServices.GetService(typeof(BarboekMVC.DAL.MySQL.ClubMySQLContext)) as iClubRetrieveContext;
            return View(context.GetAllClubs());
        }
        [HttpGet]
        public IActionResult Aanmeld()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Aanmeld(ClubModel club)
        {
           iClubSaveContext context = HttpContext.RequestServices.GetService(typeof(BarboekMVC.DAL.MySQL.ClubMySQLContext)) as iClubSaveContext;
            iClubRetrieveContext retcontext = HttpContext.RequestServices.GetService(typeof(BarboekMVC.DAL.MySQL.ClubMySQLContext)) as iClubRetrieveContext;
            bool check = retcontext.CheckValidate(club);
            if((int)club.Type == 0)
            {
                club.Test = "Demo";
            }
            else
            {
                club.Test = "Jaarabonement";
            }
            if (!check)
            {
                context.InsertAddress(club);
                ClubModel id = retcontext.FindAddressByCode(club.ZipCode);
                club.AID = id.AID;
                context.InsertClub(club);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("Name", "User with this name already exists.");
                return View("Aanmeld");
            }

        }
    }
}