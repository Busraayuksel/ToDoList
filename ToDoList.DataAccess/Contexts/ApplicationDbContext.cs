using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9NMO9KA;Database=ToDoList;Trusted_Connection=True;");


        }
        // database tables can be added by this code
        public DbSet<Mission> Missions { get; set; } // tablo oluşturmayı sağlayan kod 
        public DbSet<Group> Groups { get; set; }
    }
}
