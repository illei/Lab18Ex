using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab18Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab18Ex.DatabaseStuff
{
    internal class AutoParkDBContext : DbContext
    {

        public DbSet<Car> Cars { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Key> Keys { get; set; }
        public DbSet<UserManual> UserManuals { get; set; }
        public AutoParkDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\illei\source\repos\Laboratorul 18\Lab18Ex\Lab18Ex\DBContext\AutoParkDB.mdf"";Integrated Security=True");
        }

    }
}
