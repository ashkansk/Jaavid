using System;

namespace MachineCalculator.UI.Entities
{
	public class KhaakriziBaarbariStep : ProjectStep
	{
		public KhaakriziBaarbariStep()
		{
			OperatorFactorQuof = 1;
			EnvironmentFactorQuof = 0.9m;
			ExpertJudgementFactorQuof = 1;
		}

		public override decimal MachinePower // Q
		{
			get
			{
				if (TotalCycleDuration == 0) // prevent divide by zero
					return 0;
				return MachineCapacity / TotalCycleDuration;
			}
		}

		public override decimal TotalCycleDuration // T
		{
			get
			{
				return base.TotalCycleDuration + CustomParam1; // Add T0 
			}
		}

		public override decimal CustomParam1 // T0
		{
			get
			{
				if (CustomParam2 == 0) // prevent divide by zero
					return 0;
				return MachineCapacity / CustomParam2;
			}

			set
			{
				// do nothing
			}
		}

		public override decimal CustomParam2 // Qp (loader power in previous step)
		{
			get
			{
				return base.CustomParam2;
			}

			set
			{
				base.CustomParam2 = value;
			}
		}


		public override decimal DepartureDuration // T1
		{
			get
			{
				if (DepartureSpeed == 0) // prevent divide by zero
					return 0;
				return TotalDistance / DepartureSpeed;
			}
		}

		public override decimal ReturnDuration // T2
		{
			get
			{
				if (ReturnSpeed == 0) // prevent divide by zero
					return 0;
				return TotalDistance / ReturnSpeed;
			}
		}

		public override decimal SoilInflationQuof // this param is not used in this step
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}
}
