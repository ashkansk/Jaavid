using System.Collections.Generic;

namespace MachineCalculator.UI.Entities
{
	public class ProjectSite : IEntity
	{
		public int ID { get; set; }
		public int ProjectID { get; set; }
		public int SoilTypeIndex { get; set; }
		public double SoilVolume { get; set; }
		public List<ProjectStep> Steps { get; set; }
	}
}
