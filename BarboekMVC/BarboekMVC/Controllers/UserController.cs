using BarboekMVC.Interface;
using BarboekMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Newtonsoft.Json;

namespace BarboekMVC.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Confirm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Confirm(UserModel user)
        {
            iUserSaveContext context = HttpContext.RequestServices.GetService(typeof(BarboekMVC.DAL.MySQL.UserMySQLContext)) as iUserSaveContext;
            iUserRetrieveContext retcontext = HttpContext.RequestServices.GetService(typeof(BarboekMVC.DAL.MySQL.UserMySQLContext)) as iUserRetrieveContext;        
                if (retcontext.CheckValidate(user) == false)            
                {                
                    context.InsertUser(user);               
                    return View("~/Views/Home/Index.cshtml");           
                }
                else         
                {
                    ModelState.AddModelError("Email", "User with this email already exists");
                    return View("Confirm");
                }
        
        }
    }
}