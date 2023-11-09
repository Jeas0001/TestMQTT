using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;

namespace EntityFramework
{
    public class MeasurementsContext : DbContext
    {
        public DbSet<Measurements> measurements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysql9.dandomain.dk;database=saaapidk_db;user=saaapidk;password=dBSensorPW_081120");
        }
    }
}
//saa-api.dk02
//dBSensorJe2
//linux214.dandomain.dk