using CTWMasterClass_WebAppActivities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Repositories
{
    public class CubeRepository
    {
        private ApplicationDbContext dbContext;

        public CubeRepository()
        {
            dbContext = new ApplicationDbContext();
        }
        public List<Cube> GetAllCubes()
        {
            return dbContext.Cubes.ToList();
        }
        public void AddCube(Cube toAdd)
        {
            dbContext.Cubes.Add(toAdd);
            dbContext.SaveChanges();
        }
        public Cube GetCubeById(int Id)
        {
            return dbContext.Cubes.Find(Id);
        }
        public void DeleteCube(Cube toDelete)
        {
            dbContext.Cubes.Remove(toDelete);
            dbContext.SaveChanges();
        }
        public void SaveEdits(Cube toSave)
        {
            dbContext.Entry(toSave).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}