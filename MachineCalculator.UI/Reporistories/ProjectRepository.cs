
using MachineCalculator.UI.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MachineCalculator.UI.Reporistories
{
	public class ProjectRepository : RepositoryBase<Project>, IRepository<Project>
	{
		public ProjectRepository(InMemoryDB db)
			: base(db)
		{ }

	}
}
