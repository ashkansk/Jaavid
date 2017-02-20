using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Repositories
{
	public class MachineValidOperationRepository : RepositoryBase<MachineValidOperation>, IRepository<MachineValidOperation>
	{
		public MachineValidOperationRepository(InMemoryDB db)
			: base(db)
		{ }
	}
}
