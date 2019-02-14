using CIS174MVCApp.Models;
using CIS174MVCApp.Shared.Enums;
using CIS174MVCApp.Shared.Orchestrators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS174MVCApp.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            var profileOrchestrator = new ProfileOrchestrator();

            var model = new StudentModel
            {
                FirstName = "Jacob",
                LastName = "Johnson",
                Gender = GenderEnum.Male,
                Age = 34,
                Major = "OOP"

            };

            return View(model);
        }
    }
}