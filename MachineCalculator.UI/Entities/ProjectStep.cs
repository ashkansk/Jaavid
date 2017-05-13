using PostSharp.Patterns.Model;
using System;

namespace MachineCalculator.UI.Entities
{
	[NotifyPropertyChanged]
	public abstract class ProjectStep : IEntity
	{
		public ProjectStep()
		{
			OperatorFactorQuof = 0.75m;
			EnvironmentFactorQuof = 0.9m;
			ExpertJudgementFactorQuof = 1;
			FixedOverheadDuration = 0.05m;
		}

		public int ID { get; set; }
		public int ProjectID { get; set; }
		public int StepIndex { get; set; }
		public int StepTypeIndex { get; set; }

		// machine info
		public decimal MachineCapacity { get; set; } // C
		public virtual decimal MachinePower
		{
			get
			{
				if (SoilInflationQuof * TotalCycleDuration == 0) // prevent divide by zero
					return 0;
				decimal pow = (60 * MachineCapacity * MachineEfficiency * CustomParam1) / (SoilInflationQuof * TotalCycleDuration);
				return pow;
			}
		} // Q
		[IgnoreAutoChangeNotification]
		public decimal MachinePowerReal
		{
			get
			{
				return MachinePower * EnvironmentFactorQuof * OperatorFactorQuof * ExpertJudgementFactorQuof;
			}
		}
		public decimal MachineEfficiency { get; set; } // E
		public decimal DepartureSpeed { get; set; } // V1
		public decimal ReturnSpeed { get; set; } // V2
		public abstract decimal DepartureDuration { get; } // T1
		public abstract decimal ReturnDuration { get; } // T2
		public virtual decimal TotalCycleDuration // T
		{
			get
			{
				return DepartureDuration + ReturnDuration + FixedOverheadDuration;
			}
		}
		public virtual decimal FixedOverheadDuration { get; set; } // T3
		[IgnoreAutoChangeNotification]
		public decimal RequiredMachineCount
		{
			get
			{
				if (MachinePowerReal <= 0) // prevent divide by zero
					return 0;
				return (WorkToDo / MachinePowerReal);
			}
		}

		[IgnoreAutoChangeNotification]
		public int RequiredMachineCountReal
		{
			get
			{
				return Convert.ToInt32(Math.Ceiling(RequiredMachineCount));
			}
		}
		// machine info - end

		// soil info
		public int SoilTypeIndex { get; set; }
		public decimal SoilVolume { get; set; } // 
		public abstract decimal SoilInflationQuof { get; } // f
		public decimal Tilt { get; set; } // S
										  // soil info - end

		// quofficients
		public decimal OperatorFactorQuof { get; set; }
		public decimal EnvironmentFactorQuof { get; set; }
		public decimal ExpertJudgementFactorQuof { get; set; }
		// quofficients - end

		// work info
		public decimal TotalDistance { get; set; }
		public decimal WorkToDo { get; set; }
		public decimal WorkToDoLooseSoil
		{
			get
			{
				switch ((SoilType)SoilTypeIndex)
				{
					case SoilType.SangShekaste:
						return WorkToDo * 1.15m;
					case SoilType.ZaminTabiee:
						return WorkToDo * 1.39m;
					case SoilType.Ros:
						return WorkToDo * 1.41m;
					case SoilType.Maaseh:
						return WorkToDo * 1.18m;
					default:
						return 0;
				}
			}
		}
		// work info - end

		// custom params
		public virtual decimal CustomParam1 { get; set; }
		public virtual decimal CustomParam2 { get; set; }
		public virtual decimal CustomParam3 { get; set; }
		// end - custom params
	}
}
