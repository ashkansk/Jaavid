using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Repositories
{
	public class MachineRepository : RepositoryBase<Machine>, IRepository<Machine>
	{
		public MachineRepository(InMemoryDB db)
			: base(db)
		{ }
	}
}
