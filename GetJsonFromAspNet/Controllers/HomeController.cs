using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetJsonFromAspNet.Repositories;
using Newtonsoft.Json;
using GetJsonFromAspNet.ActionResults;

namespace GetJsonFromAspNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPeopleViaJson()
        {
            var peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetPeople();

            return Json(people);
        }


        public ActionResult GetTime()
        {

            var time = new { Title = "Время", Time = DateTime.Now.ToString() };
            return Json(time);
        }
    }
}
