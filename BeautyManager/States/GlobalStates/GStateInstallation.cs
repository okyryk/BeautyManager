using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

using BeautyManager.States.GlobalStates;

using BeautyManager.DatabaseContext;

namespace BeautyManager.States.GlobalStates
{
	class GStateInstallation : IState
	{
		public void Execute(AppState AppData)
		{
			try
			{
				using (var db = new LocalDatabaseContext())
				{
					//db.Database.EnsureDeleted();

					db.Database.Migrate();
					//db.Database.EnsureDeleted();
					//db.Database.EnsureCreated();
				}
			}
			catch (Exception e)
			{
				App.Logger.Error(e, "LocalDatabase migration.");
			}
			AppData.ExitRequest();
		}
	}
}
