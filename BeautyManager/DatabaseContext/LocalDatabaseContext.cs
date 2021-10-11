using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Xamarin.Forms;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

using BeautyManager.Entities;

using BeautyManager.Behaviors.Database;


namespace BeautyManager.DatabaseContext
{
	public class LocalDatabaseContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		protected override void
		OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var dbPath = string.Empty;
			switch (Device.RuntimePlatform)
			{
				case Device.Android:
					dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Constants.DatabaseFilename);
					break;
				case Device.iOS:
					dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", Constants.DatabaseFilename);
					break;
				default:
					dbPath = Constants.DatabasePath;
					break;
			}
			optionsBuilder.UseSqlite($"Filename={dbPath}");
		}
	}
}
