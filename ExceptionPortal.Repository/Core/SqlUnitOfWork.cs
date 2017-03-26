using ExceptionPortal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPortal.Repository.Core
{
	public class SqlUnitOfWork<T> : IUnitOfWork<T> where T : class, IEntity
	{
		private DbContext _db;
		public SqlUnitOfWork(DbContext context)
		{
			_db = context;
		}

		public IRepository<T> Repistory {
			get {
				return new SqlRepository<T>(_db);
			}
		}

		public int Commit()
		{
			return _db.SaveChanges();
		}

		public Task<int> CommitAsync()
		{
			return _db.SaveChangesAsync();
		}

		public object GetContext()
		{
			return _db;
		}

		public IRepository<TEntity> GetTypeRepository<TEntity>() where TEntity : class, IEntity
		{
			return new SqlRepository<TEntity>(_db);
		}
	}
}
