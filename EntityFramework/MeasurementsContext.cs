using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using MySql.EntityFrameworkCore.Extensions;

namespace EntityFramework
{
    public class MeasurementsContext : DbContext
    {
        public DbSet<Measurements> measurements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");
        }
    }
}