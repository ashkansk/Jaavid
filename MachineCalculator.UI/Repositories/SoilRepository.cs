using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Repositories
{
	public class SoilRepository : RepositoryBase<Soil>, IRepository<Soil>
	{
		public SoilRepository(InMemoryDB db)
			: base(db)
		{ }
	}
}
