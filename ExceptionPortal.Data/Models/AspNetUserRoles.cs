using System;
using System.Collections.Generic;

namespace ExceptionPortal.Data.Models
{
    public partial class AspNetUserRoles : IEntity
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public Guid EntityGuid { get; set; }

        public virtual AspNetRoles Role { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
