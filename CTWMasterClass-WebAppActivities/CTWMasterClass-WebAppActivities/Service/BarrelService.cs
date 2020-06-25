using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Service
{
    public class BarrelService
    {
        private BarrelRepository repository;

        public BarrelService()
        {
            repository = new BarrelRepository();
        }

        public List<Barrel> GetAllBarrels()
        {
            return repository.GetAllBarrels();
        }
        public void AddBarrel(Barrel toAdd)
        {
            repository.AddBarrel(toAdd);
        }
        public Barrel GetBarrelById(int Id)
        {
            return repository.GetBarrelById(Id);
        }
        public void SaveEdits(Barrel toSave)
        {
            repository.SaveEdits(toSave);
        }
    }
}