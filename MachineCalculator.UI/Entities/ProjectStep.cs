using PostSharp.Patterns.Model;
using System;

namespace MachineCalculator.UI.Entities
{
	[NotifyPropertyChanged]
	public class ProjectStep : IEntity
	{
		public ProjectStep()
		{
			OperatorFactorQuof = EnvironmentFactorQuof = ExpertJudgementFactorQuof = 1;
			FixedDuration = 0.05;
		}

		public int ID { get; set; }
		public int ProjectID { get; set; }
		public int StepIndex { get; set; }
		public int StepTypeIndex { get; set; }

		public string Title { get; set; }

		// machine info
		public double MachineCapacity { get; set; }
		public double MachinePower { get; set; }
		public double MachineEfficiency { get; set; }
		public double DepartureSpeed { get; set; }
		public double ReturnSpeed { get; set; }
		public double DepartureDuration { get; set; }
		public double ReturnDuration { get; set; }
		public double TotalCycleDuration { get; set; }
		public double FixedDuration { get; set; }
		public double JaamEfficiencyQuof { get; set; }
		// machine info - end

		// soil info
		public int SoilTypeIndex { get; set; }
		public double SoilVolume { get; set; }
		public double SoilInflationQuof { get; set; }
		public double Tilt { get; set; }
		public double TiltQuof { get; set; }
		// soil info - end

		// quofficients
		public double OperatorFactorQuof { get; set; }
		public double EnvironmentFactorQuof { get; set; }
		public double ExpertJudgementFactorQuof { get; set; }
		// quofficients - end

		// work info
		public double TotalDistance { get; set; }
		public double WorkToDo { get; set; }
		public int PassCount { get; set; }
		// work info - end

		[IgnoreAutoChangeNotification]
		public double RequiredMachineCount
		{
			get
			{
				if (MachinePowerReal <= 0)
					return 0;
				return (WorkToDo / MachinePowerReal);
			}
		}
		[IgnoreAutoChangeNotification]
		public double MachinePowerReal
		{
			get
			{
				return MachinePower * EnvironmentFactorQuof * OperatorFactorQuof * ExpertJudgementFactorQuof;
			}
		}

		public int RequiredMachineCountReal
		{
			get
			{
				return (int)Math.Ceiling(RequiredMachineCount);
			}
		}
	}
}
