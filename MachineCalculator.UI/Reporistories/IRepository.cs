﻿
using MachineCalculator.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MachineCalculator.UI.Reporistories
{
	public interface IRepository<TEntity>
		where TEntity: class, IEntity, new()
	{
		List<TEntity> Get(Expression<Func<TEntity, bool>> filter);
		void Insert(TEntity entity);
		void Update(TEntity entity);
		void Delete(TEntity entity);
		void Delete(int id);
	}
}
