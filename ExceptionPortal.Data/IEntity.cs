using System;

namespace ExceptionPortal.Data
{
	public interface IEntity
	{
		Guid EntityGuid { get; set; }
        bool IsSuppressed { get; set; }
        DateTime CreatedDt { get; set; }
        int CreatedByUserId { get; set; }
        DateTime? UpdatedDt { get; set; }
        int? UpdatedByUserId { get; set; }
        Guid LastUpdateGuid { get; set; }
    }
}