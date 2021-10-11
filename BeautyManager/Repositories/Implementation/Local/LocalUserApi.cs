using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BeautyManager.Entities;
using BeautyManager.Repositories.Interfaces;
using BeautyManager.DatabaseContext;

namespace BeautyManager.Repositories.Implementation.Local
{
	public class LocalUserApi : IUserApi
	{
		public async Task<User> GetUser(string userId)
		{
			using (var db = new LocalDatabaseContext())
			{
				return await  db.Users.FindAsync(userId);
			}
		}

		public Task<IEnumerable<User>> GetUsers()
		{
			throw new NotImplementedException();
		}

		public Task UpdateUser(User user)
		{
			throw new NotImplementedException();
		}
	}
}
