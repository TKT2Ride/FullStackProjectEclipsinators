using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
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
        public List<Cube> GetAllCubes()
        {
            return repository.GetAllCubes();
        }
        public void AddBarrel(Barrel toAdd)
        {
            repository.AddBarrel(toAdd);
        }
        public void SaveEdits(Barrel toSave)
        {
            repository.SaveEdits(toSave);
        }
        public void DeleteBarrel(Barrel barrel)
        {
            repository.DeleteBarrel(barrel);
        }
        public Barrel GetBarrelById(int Id)
        {
            return repository.GetBarrelById(Id);
        }

        public void AddCube(Cube toAdd)
        {
            repository.AddCube(toAdd);
        }
    }
}