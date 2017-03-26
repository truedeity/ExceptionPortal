using ExceptionPortal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ExceptionPortal.Repository.Core
{
	public class SqlRepository<T> : IRepository<T> where T : class, IEntity
	{
		protected readonly DbSet<T> _objectSet;
		protected DbContext _context;

		public SqlRepository(DbContext context)
		{
			_objectSet = context.Set<T>();
			this._context = context;
		}

		public void Add(T item)
		{
			_objectSet.Add(item);
		}

		public void Update(T item)
		{
			_context.Entry(item).State = EntityState.Modified;
		}

		public void Remove(T item)
		{
			_objectSet.Remove(item);
		}

		public T First(Expression<Func<T, bool>> predicate, params string[] path)
		{
			IQueryable<T> query = _objectSet;
			if (path != null)
			{
				foreach (var item in path)
				{
					query = query.Include(item);
				}

			}

			return query.FirstOrDefault(predicate);
		}

		public T First<TProperty>(Expression<Func<T, bool>> predicate, params Expression<Func<T, TProperty>>[] path)
		{
			IQueryable<T> query = _objectSet;
			foreach (var item in path)
			{
				query = query.Include(item);
			}
			return query.First(predicate);
		}

		public IQueryable<T> Where<TProperty>(Expression<Func<T, bool>> predicate, params Expression<Func<T, TProperty>>[] path)
		{
			IQueryable<T> query = _objectSet;
			foreach (var item in path)
			{
				query = query.Include(item);
			}

			return query.Where(predicate);
		}

		public IQueryable<T> Where(Expression<Func<T, bool>> predicate, params string[] includes)
		{
			IQueryable<T> query = _objectSet;
			foreach (var item in includes)
			{
				query = query.Include(item);
			}
			return query.Where(predicate);
		}


		public IQueryable<T> All<TProperty>(params Expression<Func<T, TProperty>>[] path)
		{
			IQueryable<T> query = _objectSet;
			if (path != null)
			{
				foreach (var item in path)
				{
					query = query.Include(item);
				}
			}
			return query;
		}

		public IQueryable<T> All(params string[] path)
		{
			IQueryable<T> query = _objectSet;
			if (path != null)
			{
				foreach (var item in path)
				{
					query = query.Include(item);
				}
			}
			return query;
		}

		public T Find(object id)
		{
			return _objectSet.Find(id);
		}

		public void Attach(T item)
		{
			T old = _objectSet.Local.FirstOrDefault(i => i.EntityGuid == item.EntityGuid);
			if (old != null)
			{
				_context.Entry<T>(old).State = EntityState.Detached;
			}
			_objectSet.Attach(item);
		}


		public System.Threading.Tasks.Task<T> FirstAsync(Expression<Func<T, bool>> predicate, params string[] path)
		{
			IQueryable<T> query = _objectSet;
			if (path != null)
			{
				foreach (var item in path)
				{
					query = query.Include(item);
				}
			}
			return query.FirstOrDefaultAsync(predicate);
		}
	}
}
