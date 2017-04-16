using System;

namespace MachineCalculator.UI.Entities
{
	public class KhaakriziPakhshStep : ProjectStep
	{
		public override decimal CustomParam1 // es (tilt quofficient)
		{
			get
			{
				return (-2.3m) * Tilt / 100 + 1;
			}

			set
			{
				// do nothing
			}
		}

		public override decimal DepartureDuration // T1
		{
			get
			{
				if (DepartureSpeed == 0) // prevent divide by zero
					return 0;
				decimal retVal = (TotalDistance * 0.06m) / DepartureSpeed;
				return retVal;
			}
		}

		public override decimal ReturnDuration // T2
		{
			get
			{
				if (ReturnSpeed == 0) // prevent divide by zero
					return 0;
				decimal retVal = (TotalDistance * 0.06m) / ReturnSpeed;
				return retVal;
			}
		}

		public override decimal SoilInflationQuof // f
		{
			get
			{
				switch ((SoilType)SoilTypeIndex)
				{
					case SoilType.SangShekaste:
						return 1.5m;
					case SoilType.ZaminTabiee:
						return 1.39m;
					case SoilType.Ros:
						return 1.41m;
					case SoilType.Maaseh:
						return 1.18m;
					default:
						return 0;
				}
			}
		}
	}
}
