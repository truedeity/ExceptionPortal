using System;
using System.Collections.Generic;

namespace ExceptionPortal.Data.Models
{
    public partial class AspNetUserClaims : IEntity
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string UserId { get; set; }
        public Guid EntityGuid { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
