using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BeautyManager.Entities;
using BeautyManager.Repositories.Interfaces;

namespace BeautyManager.Repositories.Implementation.Remote
{
	public class RemoteUserApi : IUserApi
	{
		public Task<User> GetUser(string userId)
		{
			throw new NotImplementedException();
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
