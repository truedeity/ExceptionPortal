using System;

namespace ExceptionPortal.Data
{
	public interface IEntity
	{
		Guid EntityGuid { get; set; }
	}
}