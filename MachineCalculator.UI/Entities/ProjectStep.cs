using PostSharp.Patterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MachineCalculator.UI.Entities
{
	[NotifyPropertyChanged]
	public class ProjectStep : IEntity
	{
		private Machine _machine;
		public ProjectStep()
		{
			ExpertJudgementQuofficient = 1;
		}
		public int ID { get; set; }
		public int ProjectSiteID { get; set; }
		public string Title { get; set; }
		public int MachineID { get; set; }
		public int StepIndex { get; set; }
		public int StepTypeIndex { get; set; }
		public double ExpertJudgementQuofficient { get; set; }
		public double WorkQuantity { get; set; }
		public double EnvironmentFactor { get; set; }
		public double WorkToDo { get; set; }
		[IgnoreAutoChangeNotification]
		public double CurrentMachinePerformance {
			get
			{
				if (CurrentMachine == null)
					return 0;
				Func<double, double> func = CurrentMachine.Performances.Where(p => p.SoilTypeIndex == StepTypeIndex && p.Indicator == EnvironmentFactor).First().PerformanceFormula.Compile();
				return func(WorkQuantity);
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
				return CurrentMachinePerformance * ExpertJudgementQuofficient;
			}
		}

		public int RealRequiredMachineCount
		{
			get
			{
				return (int)Math.Ceiling(RequiredMachineCount);
			}
		}

		[IgnoreAutoChangeNotification]
		public Machine CurrentMachine {
			get
			{
				if (MachineID > 0 && (_machine == null || _machine.ID != MachineID))
				{
					_machine = Factory.GetMachineRepository().Get(m => m.ID == MachineID).SingleOrDefault();
					_machine.Performances = Factory.GetMachinePerformanceRepository().Get(p => p.MachineID == _machine.ID);
				}
				return _machine;
			}
		}
	}
}
