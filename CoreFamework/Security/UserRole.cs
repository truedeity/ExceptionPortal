using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreFamework.Security
{
    public partial class UserRole : IdentityRole<int>
    {
        [Key]
        [Column("UserRoleId")]
        public new int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public bool IsSuppressed { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedByUserId { get; set; }
        public Guid LastUpdateGuid { get; set; }
        public Guid EntityGuid { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
