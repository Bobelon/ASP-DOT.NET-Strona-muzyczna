using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /* TODO: pobieranie nowości z bazy danych
             * - najnowszy zespół
             * - najnowsza piosenka
             * - najnowszy artysta
             * */
            ViewBag.NewBandImg = "http://www.sbs.com.au/popasia/sites/sbs.com.au.popasia/files/black-pink.jpg";
            ViewBag.NewBandHeader = "Black Pink";
            ViewBag.NewBandType = "Girls band";
            ViewBag.NewBandDate = "01.06.2016";
            ViewBag.NewBandSex = ViewBag.NewBandType == "Girls band" ? "członkiń" : "członków";
            ViewBag.NewBandMembers = "4";

            ViewBag.NewSondHeader = "Nowa piosenka";
            ViewBag.NewArtistHeader = "Nowy artysta";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}