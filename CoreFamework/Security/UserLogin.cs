using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreFamework.Security
{
	public partial class UserLogin
	{
		[Key]
		public int UserLoginId { get; set; }
		public Guid EntityGuid { get; set; }
		public int UserId { get; set; }
		public string LoginProvider { get; set; }
		public string ProviderKey { get; set; }
		public bool IsSuppressed { get; set; }
		public DateTime CreatedDt { get; set; }
		public int CreatedByUserId { get; set; }
		public DateTime? UpdatedDt { get; set; }
		public int? UpdatedByUserId { get; set; }
		public Guid LastUpdateGuid { get; set; }

		public virtual User User { get; set; }
	}
}
