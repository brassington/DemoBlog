using DemoBlog.Adapter.Data;
using DemoBlog.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoBlog.Controllers
{
    public class HomeController : Controller
    {
        IPostAdapter _postAdapter;

        public HomeController()
        {
            _postAdapter = new DataPostAdapter();
        }

        public HomeController(IPostAdapter postAdapter)
        {
            _postAdapter = postAdapter;
        }


        public ActionResult Index()
        {
            var model = _postAdapter.GetListPostsViewModel();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
