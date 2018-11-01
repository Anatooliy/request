using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Requests.BusinessModels;

namespace Requests.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       // [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult RequestWriteToFile()
        {
            string requestType = Request.RequestType;
            string ip = Request.UserHostAddress; 
            string url = Request.RawUrl;

            Writer writer = new Writer(requestType, ip, url);
            writer.WriteToFile();

            return View("Index");
        }
       
    }
}