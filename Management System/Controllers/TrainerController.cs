using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Management_System.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace Management_System.Controllers
{
    public class TrainerController : Controller
    {
        ApplicationUserManager _userManager;
        ApplicationDbContext _dbContext;

        public TrainerController()
        {
            _dbContext = new ApplicationDbContext();
        }
       
        // GET: Trainer
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Assigned_Course()
        {
            //var getcurrentId = User.Identity.GetUserId();
            //var userManager = 
            //    .Where(t=>t.Id == getcurrentId)
            //    .SelectMany(t=>t.Email)
            //    .ToList();
            var users = _dbContext.Users.ToList();

            return View(users);
        }
    }
}