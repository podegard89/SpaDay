using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (verify == newUser.Password)
            {
                ViewBag.name = newUser.Username;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Error: Passwords did not match. Please Try again.";
                return View("Add");
            }
        }
    }
}
