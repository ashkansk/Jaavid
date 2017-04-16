using System;

namespace MachineCalculator.UI.Entities
{
	public class KhaakriziTarakomStep : ProjectStep
	{
		public KhaakriziTarakomStep()
		{
			OperatorFactorQuof = EnvironmentFactorQuof = ExpertJudgementFactorQuof = 1;
		}

		public override decimal MachinePower
		{
			get
			{
				// DepartureSpeed is S (roller speed), MachineCapacity is w (width of roller), TotalDistance is D (soil height)
				if (CustomParam1 == 0) // prevent divide by zero
					return 0;
				return 10 * DepartureSpeed * MachineCapacity * MachineEfficiency * TotalDistance / CustomParam1;
			}
		}

		public override decimal CustomParam1 // N (roller pass count)
		{
			get
			{
				return base.CustomParam1;
			}

			set
			{
				base.CustomParam1 = value;
			}
		}

		public override decimal DepartureDuration // this property is not used in this step
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public override decimal ReturnDuration // this property is not used in this step
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public override decimal SoilInflationQuof // this property is not used in this step
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}
}
