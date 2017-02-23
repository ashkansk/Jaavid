using System;
using System.Linq.Expressions;

namespace MachineCalculator.UI.Entities
{
	public class MachinePerformance : IEntity
	{
		public int ID { get; set; }
		public int MachineID { get; set; }
		public int Indicator { get; set; }
		public int SoilTypeIndex { get; set; }
		public Expression<Func<double, double>> PerformanceFormula { get; set; }
	}
}
