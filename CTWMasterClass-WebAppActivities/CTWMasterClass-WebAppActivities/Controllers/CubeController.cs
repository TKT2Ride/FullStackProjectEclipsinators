using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class CubeController : Controller
    {
        private CubeService service = new CubeService();
        // GET: Cube
        public ActionResult Index()
        {
            return View(service.GetAllCubes());
        }
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube Cube = service.GetCubeById((int)Id);
            if (Cube == null)
            {
                return HttpNotFound();
            }
            return View(Cube);
        }
        public ActionResult CubeHomePage()
        {
            return View();
        }
    }
}
