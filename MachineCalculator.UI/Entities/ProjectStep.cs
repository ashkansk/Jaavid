using System.Collections.Generic;

namespace MachineCalculator.UI.Entities
{
	public class ProjectStep : IEntity
	{
		public ProjectStep()
		{
			StepSoils = new List<ProjectStepSoil>();
		}
		public int ID { get; set; }
		public int ProjectID { get; set; }
		public int StepIndex { get; set; }
		public int StepTypeIndex { get; set; }

		public List<ProjectStepSoil> StepSoils { get; set; }
	}
}
