/*using System.Collections.Generic;
using System.Threading.Tasks;

using SQLite;
using BeautyManager.Behaviors.Database;
using BeautyManager.Models;

namespace BeautyManager.Data
{
	public class LocalDatabase
	{
		static SQLiteAsyncConnection Database;

		public static readonly AsyncLazy<LocalDatabase> Instance = new AsyncLazy<LocalDatabase>(async () =>
		{
			var instance = new LocalDatabase();
			CreateTableResult result = await Database.CreateTableAsync<User>();
			return instance;
		});

		public LocalDatabase()
		{
			Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
		}

        #region User
        public Task<User> GetUserAsync(int id)
        {
            return Database.Table<User>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(User item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteUserAsync(User item)
        {
            return Database.DeleteAsync(item);
        }
        #endregion
    }
}
*/