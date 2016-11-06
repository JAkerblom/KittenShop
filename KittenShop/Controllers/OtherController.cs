using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace KittenShop.Controllers
{
    //[Authorize]
    public class OtherController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Help()
        //{
        //    return View();
        //}
    }
}
