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
        public bool IsSuppressed { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedByUserId { get; set; }
        public Guid LastUpdateGuid { get; set; }
        public Guid EntityGuid { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
