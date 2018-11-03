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

      
        public ActionResult RequestWriteToFile()
        {            
            //string requestType = Request.RequestType;
            string requestType = Request.GetHttpMethodOverride();;
            string ip = Request.UserHostAddress; 
            string url = Request.RawUrl;

            Writer writer = new Writer(requestType, ip, url);
            writer.WriteToFile();
            
            return View("Index");
        }
       
    }
}