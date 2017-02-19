
namespace MachineCalculator.UI.Entities
{
	public class SoilInfo : IEntity
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
		public int TypeIndex { get; set; }
		public double InflationQuofficient { get; set; }
	}
}
