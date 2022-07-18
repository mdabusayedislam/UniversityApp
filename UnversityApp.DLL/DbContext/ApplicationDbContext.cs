using Microsoft.EntityFrameworkCore;
using UnversityApp.DLL.Models;

namespace UnversityApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Department> Departments { get; set; }


    }
}
