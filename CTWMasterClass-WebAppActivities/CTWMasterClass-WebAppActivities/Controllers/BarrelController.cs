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
    public class BarrelController : Controller
    {
        private BarrelService service = new BarrelService();
        private CubeService serviceCube = new CubeService();
        private int quantity;
        // GET: Barrel
        public ActionResult Index()
        {
            return View(service.GetAllBarrels());
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreateCube()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Barrel barrel)
        {
            if (ModelState.IsValid)
            {
                service.AddBarrel(barrel);
                return RedirectToAction("Index");
            }

            return View(barrel);
        }
        public ActionResult CreateCube(Cube cube)
        {
            if (ModelState.IsValid)
            {
                serviceCube.AddCube(cube);
                return RedirectToAction("Index");
            }

            return View(cube);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barrel barrel = service.GetBarrelById((int)id);
            if (barrel == null)
            {
                return HttpNotFound();
            }
            return View(barrel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Barrel barrel = service.GetBarrelById(id);
            service.DeleteBarrel(barrel);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barrel barrel = service.GetBarrelById((int)id);
            if (barrel == null)
            {
                return HttpNotFound();
            }
            return View(barrel);
        }

        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barrel Barrel = service.GetBarrelById((int)Id);
            if (Barrel == null)
            {
                return HttpNotFound();
            }
            return View(Barrel);
        }
        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Radius, Height, Weight, ConstructionMaterial, Contents, CurrentLocation, DateCreated ")] Barrel Barrel)
        {
            if (ModelState.IsValid)
            {
                service.SaveEdits(Barrel);
                return RedirectToAction("Index");
            }
            return View(Barrel);
        }
    }
}