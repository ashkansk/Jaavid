using MachineCalculator.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MachineCalculator.UI.Repositories
{
	public abstract class RepositoryBase<TEntity>
		where TEntity : class, IEntity, new()
	{
		private InMemoryDB _db;
		protected InMemoryDB DB
		{
			get
			{
				return _db;
			}
		}

		public RepositoryBase(InMemoryDB db)
		{
			if (db == null)
				throw new ArgumentNullException();
			_db = db;
		}

		public List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
		{
			if (filter == null)
				return DB.Set<TEntity>();
			// ELSE
			return DB.Set<TEntity>().Where(filter.Compile()).ToList();
		}

		public void Insert(TEntity entity)
		{
			List<TEntity> entities = DB.Set<TEntity>();
			int maxID = entities.Select(e => e.ID).Max();
			entity.ID = maxID + 1;
			entities.Add(entity);
		}

		public void Update(TEntity entity)
		{
			List<TEntity> entities = DB.Set<TEntity>();
			int index = entities.FindIndex(e => e.ID == entity.ID);
			if (index >= 0)
				entities[index] = entity;
		}

		public void Delete(int id)
		{
			if (id > 0)
			{
				List<TEntity> entities = DB.Set<TEntity>();
				entities.RemoveAll(p => p.ID == id);
			}
		}


		public void Delete(TEntity entity)
		{
			if (entity != null)
				Delete(entity.ID);
		}
	}
}