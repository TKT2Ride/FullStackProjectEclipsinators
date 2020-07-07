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
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube cube = serviceCube.GetCubeById((int)id);
            if (cube == null)
            {
                return HttpNotFound();
            }
            return View(cube);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cube cube = serviceCube.GetCubeById(id);
            serviceCube.DeleteCube(cube);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? Id)
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
        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Size, Weight, ConstructionMaterial, Contents, CurrentLocation, DateCreated ")] Cube cube)
        {
            if (ModelState.IsValid)
            {
                serviceCube.SaveEdits(cube);
                return RedirectToAction("Index");
            }
            return View(cube);
        }
    }
}
