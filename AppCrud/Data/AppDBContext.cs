using Microsoft.EntityFrameworkCore;
using AppCrud.Models;

namespace AppCrud.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
