using PostSharp.Patterns.Model;
using System;
using System.Linq;

namespace MachineCalculator.UI.Entities
{
	public class ProjectStepExtended : ProjectStep
	{		
		[IgnoreAutoChangeNotification]
		public double CurrentMachinePerformance
		{
			get
			{
				try
				{
					/*
					if (CurrentMachine == null)
						return 0;
					Func<double, double> func = CurrentMachine.Performances.Where(p => (p.SoilTypeIndex == 0 || p.SoilTypeIndex == SoilTypeIndex) && p.Indicator == EnvironmentFactor).First().PerformanceFormula.Compile();
					return func(WorkQuantity);
					*/
					return 0;
				}
				catch (Exception e)
				{
					return 0;
				}
			}
		}
		

		[IgnoreAutoChangeNotification]
		public double RequiredMachineCount
		{
			get
			{
				if (CurrentMachineRealPerformance <= 0)
					return 0;
				return (WorkToDo / CurrentMachineRealPerformance);
			}
		}
		[IgnoreAutoChangeNotification]
		public double CurrentMachineRealPerformance
		{
			get
			{
				return CurrentMachinePerformance * ExpertJudgementFactor;
			}
		}

		public int RealRequiredMachineCount
		{
			get
			{
				return (int)Math.Ceiling(RequiredMachineCount);
			}
		}
	}
}
