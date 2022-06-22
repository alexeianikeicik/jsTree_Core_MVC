using jsTree_Core_MVC.Models;
using Microsoft.EntityFrameworkCore;
namespace jsTree_Core_MVC
{
    public class DBCtx : DbContext
    {
        public DBCtx(DbContextOptions<DBCtx> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        /*
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<VehicleSubType> VehicleSubTypes { get; set; }
        */
    }
}