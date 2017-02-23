using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Repositories
{
	public class MachinePerformanceRepository : RepositoryBase<MachinePerformance>, IRepository<MachinePerformance>
	{
		public MachinePerformanceRepository(InMemoryDB db)
			: base(db)
		{ }
	}
}
