using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using OnlineStore.Models.Data;
using OnlineStore.Models.Repository;

namespace OnlineStore.Controllers
{ 
    
    public class HomeController : Controller
    {
        private readonly IStore<User> users;
        private readonly AppDbContext dp;

        public HomeController(IStore<User> users,AppDbContext dp)
        {
            this.users = users;
            this.dp = dp;
        }
        public IActionResult Index()
        { 
           
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            var userr = dp.Users.Where(a => a.UserName == user.UserName && a.Password == user.Password).FirstOrDefault();
            if (userr != null)
            {

            
            switch (userr.Kind)
            {
                case"Admin":
                    return RedirectToAction("Index","Admin");

                        

                    case "Comfermation":
                        return RedirectToAction("Index", "Comfermation");

                    case "OrderTaker":
                        return RedirectToAction("Index", "OrderTaker");


                }
            }
            ViewBag.ss = "Wrong Name Or Password";
            return View();



        }



       
    }
}
