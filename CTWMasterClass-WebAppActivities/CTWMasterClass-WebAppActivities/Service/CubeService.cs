using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Service
{
    public class CubeService
    {
        private CubeRepository repository;

        public CubeService()
        {
            repository = new CubeRepository();
        }

        public List<Cube> GetAllCubes()
        {
            return repository.GetAllCubes();
        }
        public void AddCube(Cube toAdd)
        {
            repository.AddCube(toAdd);
        }
        public void SaveEdits(Cube toSave)
        {
            repository.SaveEdits(toSave);
        }
        public void DeleteCube(Cube cube)
        {
            repository.DeleteCube(cube);
        }
        public Barrel GetCubeById(int Id)
        {
            return repository.GetCubeById(Id);
        }
    }
}