using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using BeautyManager.Entities;

namespace BeautyManager.Repositories.Interfaces
{
	public interface IUserApi
	{
		Task<IEnumerable<User>> GetUsers();
		Task<User> GetUser(string userId);
		Task UpdateUser(User user);
	}
}
