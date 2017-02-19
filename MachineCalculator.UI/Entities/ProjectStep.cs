using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineCalculator.UI.Entities
{
	public class ProjectStep : IEntity
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string ProjectID { get; set; }
		public int MachineID { get; set; }
		public int SoilTypeIndex { get; set; }
		public int StepIndex { get; set; }
		public int StepTypeIndex { get; set; }

	}
}
