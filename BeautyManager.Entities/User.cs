using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyManager.Entities
{
	public class User
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int LocalId { get; set; }
		public string Id { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string SureName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }

	}
}
