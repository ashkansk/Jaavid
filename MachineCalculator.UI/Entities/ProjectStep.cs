
namespace MachineCalculator.UI.Entities
{
	public class ProjectStep : IEntity
	{
		public int ID { get; set; }
		public int ProjectSiteID { get; set; }
		public string Title { get; set; }
		public int MachineID { get; set; }
		public int StepIndex { get; set; }
		public int StepTypeIndex { get; set; }
	}
}
