using Models.Models;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knorish.Controllers
{
    public class HomeController : Controller
    {
        IBoatService _IBoatService;
        public HomeController(IBoatService IBoatService)
        {
            _IBoatService = IBoatService;
        }
        [HttpPost]
        public ActionResult AddBoat(Boat model)
        {
            string Message = _IBoatService.AddBoat(model);
            return Json(new { status = true, Msg = Message });
        }
        [HttpPost]
        public ActionResult RentBoat(Boat model)
        {
            string Message = _IBoatService.RentBoat(model);
            return Json(new { status = true, Msg = Message });
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListBoat()
        {
            return View(_IBoatService.ListBoat());
        }

    }
}