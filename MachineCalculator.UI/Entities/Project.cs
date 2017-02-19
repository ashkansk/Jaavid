using System.Collections.Generic;

namespace MachineCalculator.UI.Entities
{
	public class Project : IEntity
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public int OperationTypeIndex { get; set; }
		public int ActiveDaysPerMonth { get; set; }
		public int HoursPerDay { get; set; }
		public int ActiveHoursPerDay { get; set; }
		public int WorkShiftsPerDay { get; set; }
		public List<ProjectStep> Steps { get; set; }
	}
}
