using System.Linq;
using WDG.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WDG.DataAccess.Concrete.EntityFramework
{
    public class WDGContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=WDG;Integrated Security=True");
        }

        public DbSet<kurData> kurData { get; set; }
    }
}
