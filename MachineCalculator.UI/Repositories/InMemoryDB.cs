using MachineCalculator.UI.Entities;
using System;
using System.Collections.Generic;

namespace MachineCalculator.UI.Repositories
{
	public class InMemoryDB
	{
		public InMemoryDB()
		{
			Projects = new List<Project>();
			Soils = new List<Soil>()
			{
				new Soil { ID = 1, Title = "سنگ شکسته", TypeIndex=(int)SoilType.SangShekaste, InflationQuofficient=0.5, Code="", Description="..." },
				new Soil { ID = 2, Title = "زمین طبیعی", TypeIndex=(int)SoilType.ZaminTabiee, InflationQuofficient=0.5, Code="", Description="..." },
				new Soil { ID = 3, Title = "رس", TypeIndex=(int)SoilType.Ros, InflationQuofficient=0.5, Code="", Description="..." },
				new Soil { ID = 4, Title = "ماسه", TypeIndex=(int)SoilType.Maaseh, InflationQuofficient=0.5, Code="", Description="..." },
			};
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
			else if (t == typeof(Soil))
				toReturn = Soils;
			
			return toReturn as List<TEntity>;
		}

		public List<Project> Projects { get; set; }
		public List<ProjectStep> ProjectSteps { get; set; }
		public List<Soil> Soils { get; set; }

	}
}
