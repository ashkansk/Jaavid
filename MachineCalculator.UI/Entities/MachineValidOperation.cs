
namespace MachineCalculator.UI.Entities
{
	public class MachineValidOperation : IEntity
	{
		public int ID { get; set; }
		public string MachineID { get; set; }
		public int OperationType { get; set; }
		public int ProjectStepType { get; set; }
	}
}
