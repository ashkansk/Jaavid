using PostSharp.Patterns.Model;
using System;

namespace MachineCalculator.UI.Entities
{
	[NotifyPropertyChanged]
	public class ProjectStep : IEntity
	{
		public int ID { get; set; }
		public int ProjectSiteID { get; set; }
		public string Title { get; set; }
		public int MachineID { get; set; }
		public int StepIndex { get; set; }
		public int StepTypeIndex { get; set; }
		public double ExpertJudgementQuofficient { get; set; }
		public double WorkUnitQuantity { get; set; }
		public double WorkUnitFactor1 { get; set; }
		public double WorkToDo { get; set; }
		public double CurrentMachinePerformance { get; set; }
		public double RequiredMachineCount { get; set; }
		public double CurrentRealMachinePerformance
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
	}
}
