using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class CubeController : Controller
    {
        // GET: Cube
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube Cube = service.GetBarrelById((int)Id);
            if (barrel == null)
            {
                return HttpNotFound();
            }
            return View(barrel);
        }
    }
}
