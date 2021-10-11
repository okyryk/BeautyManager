using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using BeautyManager.Entities;
using BeautyManager.Repositories.Interfaces;

using BeautyManager.Repositories.Implementation.Local;
using BeautyManager.Repositories.Implementation.Remote;

namespace BeautyManager.Repositories.Managers
{
	public class ManagerUserApi : IUserApi
	{
		private readonly IUserApi _localApi;
		private readonly IUserApi _remoteApi;

		public async Task<User> GetUser(string userId)
		{
			var user = await _remoteApi.GetUser(userId);
			await _localApi.UpdateUser(user);
			return user;
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
