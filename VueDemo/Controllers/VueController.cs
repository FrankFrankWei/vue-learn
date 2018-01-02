using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueDemo.Controllers
{
    public class VueController : Controller
    {
        // GET: Vue
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sort()
        {
            return View();
        }

        public ActionResult Ticket()
        {
            return View();
        }

        // get data via jquery ajax
        public ActionResult SingleView()
        {
            return View();
        }
        // crud via vue-resource
        public ActionResult CrudView()
        {
            return View();
        }
    }
}