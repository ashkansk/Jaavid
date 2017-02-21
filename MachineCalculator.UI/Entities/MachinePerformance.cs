using System;
using System.Linq.Expressions;

namespace MachineCalculator.UI.Entities
{
	public class MachinePerformance
	{
		public int MachineID { get; set; }
		public int Indicator { get; set; }
		public int SoilTypeIndex { get; set; }
		public Expression<Func<int, double>> PerformanceFormula { get; set; }
	}
}
