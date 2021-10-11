using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

using BeautyManager.Entities;

namespace BeautyManager.DatabaseContext
{
    public class LocalDatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        private const string DatabaseName = "BeautyManagerSQLite.db3";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DatabaseName}");
        }
    }
}
