using MachineCalculator.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineCalculator.UI.Reporistories
{
	public class MachineValidOperationRepository : RepositoryBase<MachineValidOperation>, IRepository<MachineValidOperation>
	{
		public MachineValidOperationRepository(InMemoryDB db)
			: base(db)
		{ }
	}
}
