
using System.Collections.Generic;

namespace MachineCalculator.UI.Entities
{
	public class KhaakriziProject : Project
	{
		public KhaakriziProject()
		{
			Steps = new List<ProjectStep>
			{
				new ProjectStep { ID=1,  },
				new ProjectStep { },
				new ProjectStep { },
				new ProjectStep { },
			};
		}
	}
}
