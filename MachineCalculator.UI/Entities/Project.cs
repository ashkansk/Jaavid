using System.Collections.Generic;

namespace MachineCalculator.UI.Entities
{
	public class Project : IEntity
	{
		public Project()
		{
			Steps = new List<ProjectStep>();
		}
		public int ID { get; set; }
		public string Title { get; set; }
		public int OperationTypeIndex { get; set; }
		public int ActiveDaysPerMonth { get; set; }
		public int WorkShiftsPerDay { get; set; }
		public double HoursPerShift { get; set; }
		public double ActiveHoursPerShift { get; set; }
		public double TotalActiveHoursPerMonth
		{
			get
			{
				return ActiveDaysPerMonth * WorkShiftsPerDay * ActiveHoursPerShift;
			}
		}
		public List<ProjectStep> Steps { get; set; }
	}
}
