using System;
using System.Collections.Generic;

namespace ExceptionPortal.Data.Models
{
    public partial class AspNetUserTokens : IEntity
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Guid EntityGuid { get; set; }
    }
}
