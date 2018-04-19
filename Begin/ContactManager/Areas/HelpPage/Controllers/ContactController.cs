using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Areas.HelpPage.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /HelpPage/Contact/

        public ActionResult Index()
        {
            return View();
        }

        public string[] Get()
        {
            return new string[]
    {
        "Hello",
        "World"
    };
        }
    }
    
}
