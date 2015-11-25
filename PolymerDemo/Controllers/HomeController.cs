using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PolymerDemo.DataModels;
using Newtonsoft.Json;

namespace PolymerDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Time to learn about Polymer!";
            ViewBag.Message = "Click On Me";

            return View();
        }

        public ActionResult Forms()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Cards()
        {
            CardModel cardHolder;
            List<CardModel> cardList = new List<CardModel>();

            for (int x = 0; x < 5; ++x)
            {
                cardHolder = new CardModel();

                cardHolder.index = x;
                cardHolder.content = "Content Value" + x.ToString();
                cardHolder.name = "Card " + x.ToString();

                cardList.Add(cardHolder);
            }

            return Json(cardList);
        }
    }
}