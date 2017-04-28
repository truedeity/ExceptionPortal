using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreFamework.Security
{
    public partial class UserLogin : IdentityUserLogin<int>
    {
        public int UserLoginId { get; set; }
        public Guid EntityGuid { get; set; }
        public bool IsSuppressed { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedByUserId { get; set; }
        public Guid LastUpdateGuid { get; set; }

        public virtual User User { get; set; }
    }
}
