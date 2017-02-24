using System.Collections.Generic;

namespace MachineCalculator.UI.Entities
{
	public class Project : IEntity
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public int OperationTypeIndex { get; set; }
		public int ActiveDaysPerMonth { get; set; }
		public int WorkShiftsPerDay { get; set; }
		public double HoursPerShift { get; set; }
		public double ActiveHoursPerShift { get; set; }
		public List<ProjectSite> Sites { get; set; }
	}
}
