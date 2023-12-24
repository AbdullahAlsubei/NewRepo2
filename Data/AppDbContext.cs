using HomeWork_Week_1_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork_Week_1_Project.Data
{
    public class AppDbContext : DbContext
    {
        //3- add the fullowing
        //start
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        { 
        
        }
        public DbSet<CategoriesClass> Categories { get; set; }
        //end

        public DbSet<ItemsClass> Items { get; set; }
        public DbSet<ItemsPropartiesClass> ItemsProparties { get; set; }

    }
}
