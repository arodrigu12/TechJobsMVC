using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs.Controllers
{
    public class TechJobsController : Controller
    {
        internal static Dictionary<string, string> actionChoices = new Dictionary<string, string>();

        internal static Dictionary<string, string> columnChoices = new Dictionary<string, string>();

        static TechJobsController()
        {
            //Initialize actionChoices
            actionChoices.Add("search", "Search");
            actionChoices.Add("list", "List");

            //Initialize columnChoices
            columnChoices.Add("core competency", "Skill");
            columnChoices.Add("employer", "Employer");
            columnChoices.Add("location", "Location");
            columnChoices.Add("position type", "Position Type");
            columnChoices.Add("all", "All");
        }

        public override ViewResult View()
        {
            ViewBag.actions = actionChoices;
            ViewBag.columns = columnChoices;

            return base.View();
        }

        public override ViewResult View(string viewName)
        {
            ViewBag.actions = actionChoices;
            ViewBag.columns = columnChoices;

            return base.View(viewName);
        }
    }
}
