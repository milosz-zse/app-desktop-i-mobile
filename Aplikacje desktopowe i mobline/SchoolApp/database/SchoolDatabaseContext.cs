using Microsoft.EntityFrameworkCore;
using SchoolApp.database.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.database
{
    //Add-Migration FirstMigration -OutputDir Database\Migrations
    //update-database

    class SchoolDatabaseContext : DbContext
    {
        public DbSet<SchoolClass> SchoolClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("fileName=schoolDatabse.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
    
}
