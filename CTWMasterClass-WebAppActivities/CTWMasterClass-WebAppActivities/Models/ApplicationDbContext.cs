//using CTWMasterClass_WebAppActivities.Models.Entity;
using System.Data.Entity;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CTWMasterClass_WebAppActivities.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Barrel> Barrels { get; set; }
        public DbSet<Cube> Cubes { get; set; }
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}