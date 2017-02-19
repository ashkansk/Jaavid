using MachineCalculator.UI.Entities;
using System;
using System.Collections.Generic;

namespace MachineCalculator.UI.Reporistories
{
	public class InMemoryDB
	{
		public InMemoryDB()
		{
			Projects = new List<Project>();
		}

		public List<TEntity> Set<TEntity>()
			where TEntity: class, IEntity, new()
		{
			object toReturn = null;
			Type t = typeof(TEntity);
			if (t == typeof(Project))
				toReturn = Projects;
			else if (t == typeof(ProjectStep))
				toReturn = ProjectSteps;
			
			return toReturn as List<TEntity>;
		}

		public List<Project> Projects { get; set; }
		public List<ProjectStep> ProjectSteps { get; set; }

	}
}
