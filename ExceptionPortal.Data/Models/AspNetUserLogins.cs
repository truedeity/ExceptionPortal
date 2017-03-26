using System;
using System.Collections.Generic;

namespace ExceptionPortal.Data.Models
{
    public partial class AspNetUserLogins : IEntity
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public string UserId { get; set; }
        public Guid EntityGuid { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
