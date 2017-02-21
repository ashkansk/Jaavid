
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MachineCalculator.UI.Entities
{
	public class Machine : IEntity
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public int TypeIndex { get; set; }

		public List<MachinePerformance> Performances { get; set; }
	}
}
