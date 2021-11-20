using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Dare_Academmy.Data
{
    public class contextcity : DbContext
    {
        public DbSet<Newcity> city { set; get; }

        public DbSet<Newcountry> country { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Exam;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
