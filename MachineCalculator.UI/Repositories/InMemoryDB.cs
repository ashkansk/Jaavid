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
			ProjectSites = new List<ProjectStep>();
			ProjectSteps = new List<ProjectStepSoil>();

			Machines = new List<Machine>
			{
				new Machine
				{
					ID = 1,
					Category ="Loader",
					Title ="CAT D966"
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
					Title = "HAMM"
				},
			};

			/* This performance trendline approximation formulas (using interpolation) are not required in version 2.
			 * In this version the performance calculation is based on multiple parameters entered by an expert user.
			 * Let it be comment for a while to remember me that night my eyes were so red for typing these exact numbers as precise as possible with my bloody fingers!!!
			 
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
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0046 * Math.Pow(x, 3) +  0.3818 * Math.Pow(x, 2) - 15.397 * x + 330.01) },
				new MachinePerformance { MachineID=4, Indicator=0, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.005 * Math.Pow(x, 3) +  0.412 * Math.Pow(x, 2) - 16.616 * x + 356.12) },
				new MachinePerformance { MachineID=4, Indicator=0, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0049 * Math.Pow(x, 3) +  0.4062 * Math.Pow(x, 2) - 16.38 * x + 351.07) },
				new MachinePerformance { MachineID=4, Indicator=0, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.00003 * Math.Pow(x, 4) - 0.0059 * Math.Pow(x, 3) +  0.4854 * Math.Pow(x, 2) - 19.573 * x + 419.5) },
				new MachinePerformance { MachineID=4, Indicator=10, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0036 * Math.Pow(x, 3) +  0.294 * Math.Pow(x, 2) - 11.856 * x + 254.11) },
				new MachinePerformance { MachineID=4, Indicator=10, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0038 * Math.Pow(x, 3) +  0.3173 * Math.Pow(x, 2) - 12.794 * x + 274.22) },
				new MachinePerformance { MachineID=4, Indicator=10, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0038 * Math.Pow(x, 3) +  0.3128 * Math.Pow(x, 2) - 12.613 * x + 270.33) },
				new MachinePerformance { MachineID=4, Indicator=10, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0045 * Math.Pow(x, 3) +  0.3737 * Math.Pow(x, 2) - 15.071 * x + 323.02) },
				new MachinePerformance { MachineID=4, Indicator=20, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.00001 * Math.Pow(x, 4) - 0.0025 * Math.Pow(x, 3) +  0.2062 * Math.Pow(x, 2) - 8.3145 * x + 178.2) },
				new MachinePerformance { MachineID=4, Indicator=20, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0038 * Math.Pow(x, 3) +  0.3173 * Math.Pow(x, 2) - 12.794 * x + 274.22) },
				new MachinePerformance { MachineID=4, Indicator=20, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.00001 * Math.Pow(x, 4) - 0.0027 * Math.Pow(x, 3) +  0.2225 * Math.Pow(x, 2) - 8.9725 * x + 192.31) },
				new MachinePerformance { MachineID=4, Indicator=20, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.00001 * Math.Pow(x, 4) - 0.0032 * Math.Pow(x, 3) +  0.2621 * Math.Pow(x, 2) - 10.569 * x + 226.53) },
				//machine id = 5
				new MachinePerformance { MachineID=5, Indicator=0, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0037 * Math.Pow(x, 3) +  0.3048 * Math.Pow(x, 2) - 12.293 * x + 263.47) },
				new MachinePerformance { MachineID=5, Indicator=0, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.004 * Math.Pow(x, 3) +  0.329 * Math.Pow(x, 2) - 13.266 * x + 284.32) },
				new MachinePerformance { MachineID=5, Indicator=0, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0039 * Math.Pow(x, 3) +  0.3243 * Math.Pow(x, 2) - 13.078 * x + 280.29) },
				new MachinePerformance { MachineID=5, Indicator=0, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0047 * Math.Pow(x, 3) +  0.3875 * Math.Pow(x, 2) - 15.627 * x + 334.93) },
				new MachinePerformance { MachineID=5, Indicator=10, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.00001 * Math.Pow(x, 4) - 0.0028 * Math.Pow(x, 3) +  0.2347 * Math.Pow(x, 2) - 9.4656 * x + 202.88) },
				new MachinePerformance { MachineID=5, Indicator=10, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.00001 * Math.Pow(x, 4) - 0.0031 * Math.Pow(x, 3) +  0.2533 * Math.Pow(x, 2) - 10.215 * x + 218.93) },
				new MachinePerformance { MachineID=5, Indicator=10, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.00001 * Math.Pow(x, 4) - 0.003 * Math.Pow(x, 3) +  0.2497 * Math.Pow(x, 2) - 10.07 * x + 215.82) },
				new MachinePerformance { MachineID=5, Indicator=10, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.00002 * Math.Pow(x, 4) - 0.0036 * Math.Pow(x, 3) +  0.2984 * Math.Pow(x, 2) - 12.033 * x + 257.89) },
				new MachinePerformance { MachineID=5, Indicator=20, SoilTypeIndex=(int)SoilType.SangShekaste,
					PerformanceFormula = (x => 0.000009 * Math.Pow(x, 4) - 0.002 * Math.Pow(x, 3) +  0.1646 * Math.Pow(x, 2) - 6.6382 * x + 142.28) },
				new MachinePerformance { MachineID=5, Indicator=20, SoilTypeIndex=(int)SoilType.ZaminTabiee,
					PerformanceFormula = (x => 0.00001 * Math.Pow(x, 4) - 0.0021 * Math.Pow(x, 3) +  0.1751 * Math.Pow(x, 2) - 7.0619 * x + 151.36) },
				new MachinePerformance { MachineID=5, Indicator=20, SoilTypeIndex=(int)SoilType.Ros,
					PerformanceFormula = (x => 0.00001 * Math.Pow(x, 4) - 0.0021 * Math.Pow(x, 3) +  0.1776 * Math.Pow(x, 2) - 7.1635 * x + 153.54) },
				new MachinePerformance { MachineID=5, Indicator=20, SoilTypeIndex=(int)SoilType.Maaseh,
					PerformanceFormula = (x => 0.00001 * Math.Pow(x, 4) - 0.0025 * Math.Pow(x, 3) +  0.2093 * Math.Pow(x, 2) - 8.4384 * x + 180.86) },
				// machine id = 6
				new MachinePerformance { MachineID=6, Indicator=70, SoilTypeIndex=0,
					PerformanceFormula = (x => 0.1348 * Math.Pow(x, 4) - 5.6495 * Math.Pow(x, 3) +  91.203 * Math.Pow(x, 2) - 706.13 * x + 2612.6) },
				new MachinePerformance { MachineID=6, Indicator=60, SoilTypeIndex=0,
					PerformanceFormula = (x => 0.1155 * Math.Pow(x, 4) - 4.8424 * Math.Pow(x, 3) +  78.174 * Math.Pow(x, 2) - 605.26 * x + 2239.3) },
				new MachinePerformance { MachineID=6, Indicator=50, SoilTypeIndex=0,
					PerformanceFormula = (x => 0.0963 * Math.Pow(x, 4) - 4.0353 * Math.Pow(x, 3) +  65.145 * Math.Pow(x, 2) - 504.38 * x + 1866.1) },
				new MachinePerformance { MachineID=6, Indicator=40, SoilTypeIndex=0,
					PerformanceFormula = (x => 0.077 * Math.Pow(x, 4) - 3.2283 * Math.Pow(x, 3) +  52.116 * Math.Pow(x, 2) - 403.5 * x + 1492.9) },
				new MachinePerformance { MachineID=6, Indicator=35, SoilTypeIndex=0,
					PerformanceFormula = (x => 0.0674 * Math.Pow(x, 4) - 2.8247 * Math.Pow(x, 3) +  45.601 * Math.Pow(x, 2) - 353.07 * x + 1306.3) },
				new MachinePerformance { MachineID=6, Indicator=30, SoilTypeIndex=0,
					PerformanceFormula = (x => 0.0578 * Math.Pow(x, 4) - 2.4212 * Math.Pow(x, 3) +  39.087 * Math.Pow(x, 2) - 302.63 * x + 1119.7) },
				new MachinePerformance { MachineID=6, Indicator=25, SoilTypeIndex=0,
					PerformanceFormula = (x => 0.0481 * Math.Pow(x, 4) - 2.0177 * Math.Pow(x, 3) +  32.572 * Math.Pow(x, 2) - 252.19 * x + 933.05) },
				new MachinePerformance { MachineID=6, Indicator=20, SoilTypeIndex=0,
					PerformanceFormula = (x => 0.0385 * Math.Pow(x, 4) - 1.6141 * Math.Pow(x, 3) +  26.058 * Math.Pow(x, 2) - 201.75 * x + 746.44) },
			};
			*/
		}

		public List<TEntity> Set<TEntity>()
			where TEntity : class, IEntity, new()
		{
			object toReturn = null;
			Type t = typeof(TEntity);
			if (t == typeof(Project))
				toReturn = Projects;
			else if (t == typeof(ProjectStep))
				toReturn = ProjectSites;
			else if (t == typeof(ProjectStepSoil))
				toReturn = ProjectSteps;
			else if (t == typeof(Machine))
				toReturn = Machines;
			else if (t == typeof(MachinePerformance))
				toReturn = MachinePerformances;

			return toReturn as List<TEntity>;
		}

		public List<Project> Projects { get; set; }
		public List<ProjectStepSoil> ProjectSteps { get; set; }
		public List<ProjectStep> ProjectSites { get; set; }
		public List<Machine> Machines { get; set; }
		public List<MachinePerformance> MachinePerformances { get; set; }
	}
}
