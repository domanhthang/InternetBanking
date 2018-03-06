using InternetBanking.Core.Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace InternetBanking.Data
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly CrudContext _context;
		private readonly DbSet<T> _dbSet;

		public Repository(CrudContext context)
		{
			this._context = context;
			this._dbSet = context.Set<T>();
		}

		public void Create(T entity)
		{
			_dbSet.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entityToDelete = _dbSet.Find(id);
			_dbSet.Remove(entityToDelete);
			_context.SaveChanges();
		}

		public IEnumerable<T> GetAll()
		{
			return _dbSet.ToList();
		}

		public T GetById(int id)
		{
			return _dbSet.Find(id);
		}

		public void Update(T entity)
		{
			_dbSet.Attach(entity);
			_context.Entry(entity).State = EntityState.Modified;
			_context.SaveChanges();
		}
	}
}
