using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
   
    public class CubeController : Controller
    { 
        private CubeService serviceCube = new CubeService();
        // GET: Cube
        public ActionResult Index()
        {
            return View(serviceCube.GetAllCubes());
        }
        public ActionResult CreateCube()
        {
            return View();
        }
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube cube = serviceCube.GetCubeById((int)Id);
            if (cube == null)
            {
                return HttpNotFound();
            }
            return View(cube);
        }
    }
}
