using System;

namespace MachineCalculator.UI.Entities
{
	public class KhaakriziBaargiriStep : ProjectStep
	{
		public KhaakriziBaargiriStep()
		{
			Tilt = 0.06m;
		}

		public override decimal CustomParam1 // K (Jaam efficiency quof)
		{
			get
			{
				switch ((SoilType)SoilTypeIndex)
				{
					case SoilType.SangShekaste:
						return 0.9m;
					case SoilType.ZaminTabiee:
						return 1.05m;
					case SoilType.Ros:
						return 0.9m;
					case SoilType.Maaseh:
						return 1;
					default:
						return 0;
				}
			}
		}
		public override decimal DepartureDuration // T1
		{
			get
			{
				decimal retVal = (0.0015333m + (0.023333m * Tilt / 100)) * TotalDistance;
				return retVal;
			}
		}
		public override decimal ReturnDuration // T2
		{
			get
			{
				decimal retVal = (0.00162222m + (0.028888m * Tilt / 100)) * TotalDistance;
				return retVal;
			}
		}

		public override decimal FixedOverheadDuration // T3
		{
			get
			{
				decimal c = MachineCapacity;
				decimal retVal = 0;
				if (c >= 0.6m && c < 3.3m)
					retVal = 0.5m;
				else if (c >= 3.3m && c < 5.7m)
					retVal = 0.55m;
				else if (c >= 5.7m && c < 8.7m)
					retVal = 0.6m;
				else if (c >= 8.7m && c < 20)
					retVal = 0.7m;
				return retVal;
			}
			set
			{
				// do nothing
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
						return 1.25m;
					case SoilType.Ros:
						return 1.27m;
					case SoilType.Maaseh:
						return 1.12m;
					default:
						return 0;
				}
			}
		}

	}
}
