using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Repositories
{
	public class ProjectStepSoilRepository : RepositoryBase<ProjectStepSoil>, IRepository<ProjectStepSoil>
	{
		public ProjectStepSoilRepository(InMemoryDB db)
			: base(db)
		{ }
	}
}
