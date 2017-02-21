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

			Machines = new List<Machine>
			{
				new Machine
				{
					ID = 1,
					Category ="Loader",
					Title ="بارگیر"
				},
				new Machine
				{
					ID = 2,
					Category = "Truck",
					Title = "کامیون 12 تن"
				},
				new Machine
				{
					ID = 3,
					Category = "Truck",
					Title = "کامیون 10 تن"
				},
				new Machine
				{
					ID = 4,
					Category = "Dozer",
					Title = "بولدوزر D8R"
				},
				new Machine
				{
					ID = 5,
					Category = "Dozer",
					Title = "بولدوزر k-D155"
				},
				new Machine
				{
					ID = 6,
					Category = "Roller",
					Title = "غلطک"
				},
			};

			MachinePerformances = new List<MachinePerformance>
			{
				// machine id = 1
				new MachinePerformance { MachineID=1, Indicator=0, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.0025 * Math.Pow(x, 2) - 0.5859 * x + 76.179) },
				new MachinePerformance { MachineID=1, Indicator=0, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0013 * Math.Pow(x, 2) - 0.4647 * x + 111.84) },
				new MachinePerformance { MachineID=1, Indicator=0, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0013 * Math.Pow(x, 2) - 0.4574 * x + 110.08) },
				new MachinePerformance { MachineID=1, Indicator=0, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				// machine id = 2
				new MachinePerformance { MachineID=2, Indicator=0, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.003 * Math.Pow(x, 4) - 0.124 * Math.Pow(x, 3) +  1.9836 * Math.Pow(x, 2) - 15.798 * x + 72.864) },
				new MachinePerformance { MachineID=2, Indicator=0, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0054 * Math.Pow(x, 4) - 0.221 * Math.Pow(x, 3) +  3.3832 * Math.Pow(x, 2) - 24.784 * x + 96.855) },
				new MachinePerformance { MachineID=2, Indicator=0, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0053 * Math.Pow(x, 4) - 0.2163 * Math.Pow(x, 3) +  24.369 * Math.Pow(x, 2) - 24.369 * x + 95.804) },
				new MachinePerformance { MachineID=2, Indicator=0, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.0061 * Math.Pow(x, 4) - 0.2479 * Math.Pow(x, 3) +  3.7638 * Math.Pow(x, 2) - 27.147 * x + 102.77) },
				// machine id = 3
				new MachinePerformance { MachineID=3, Indicator=0, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.0032 * Math.Pow(x, 4) - 0.1325 * Math.Pow(x, 3) +  2.0788 * Math.Pow(x, 2) - 15.953 * x + 68.446) },
				new MachinePerformance { MachineID=3, Indicator=0, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0055 * Math.Pow(x, 4) - 0.2217 * Math.Pow(x, 3) +  3.3494 * Math.Pow(x, 2) - 23.933 * x + 88.861) },
				new MachinePerformance { MachineID=3, Indicator=0, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0054 * Math.Pow(x, 4) - 0.2175 * Math.Pow(x, 3) +  3.2911 * Math.Pow(x, 2) - 23.575 * x + 87.987) },
				new MachinePerformance { MachineID=3, Indicator=0, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.0061 * Math.Pow(x, 4) - 0.2453 * Math.Pow(x, 3) +  3.6804 * Math.Pow(x, 2) - 25.954 * x + 93.752) },
				// machine id = 4
				new MachinePerformance { MachineID=4, Indicator=0, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=0, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=0, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=0, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=10, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=10, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=10, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=10, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=20, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=20, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=20, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=4, Indicator=20, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				//machine id = 5
				new MachinePerformance { MachineID=5, Indicator=0, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=0, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=0, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=0, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=10, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=10, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=10, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=10, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=20, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=20, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=20, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=5, Indicator=20, SoilTypeIndex=(int)SoilType.Maaseh,

					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				// machine id = 6
				new MachinePerformance { MachineID=6, Indicator=70, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=6, Indicator=60, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=6, Indicator=50, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=6, Indicator=40, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=6, Indicator=35, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=6, Indicator=30, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=6, Indicator=25, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
				new MachinePerformance { MachineID=6, Indicator=20, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.0015 * Math.Pow(x, 2) - 0.5186 * x + 124.82) },
			};
		}

		public List<TEntity> Set<TEntity>()
			where TEntity : class, IEntity, new()
		{
			object toReturn = null;
			Type t = typeof(TEntity);
			if (t == typeof(Project))
				toReturn = Projects;
			else if (t == typeof(ProjectStep))
				toReturn = ProjectSteps;
			else if (t == typeof(Soil))
				toReturn = Soils;
			else if (t == typeof(Machine))
				toReturn = Machines;
			else if (t == typeof(MachinePerformance))
				toReturn = MachinePerformances;

			return toReturn as List<TEntity>;
		}

		public List<Project> Projects { get; set; }
		public List<ProjectStep> ProjectSteps { get; set; }
		public List<Soil> Soils { get; set; }
		public List<Machine> Machines { get; set; }
		public List<MachinePerformance> MachinePerformances { get; set; }
	}
}
