using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Reporistories
{
	public class MachineRepository : RepositoryBase<Machine>, IRepository<Machine>
	{
		public MachineRepository(InMemoryDB db)
			: base(db)
		{ }
	}
}
