using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Repositories
{
	public class ProjectStepRepository : RepositoryBase<ProjectStep>, IRepository<ProjectStep>
	{
		public ProjectStepRepository(InMemoryDB db)
			: base(db)
		{ }
	}
}
