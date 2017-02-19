using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Reporistories
{
	public class ProjectStepRepository : RepositoryBase<ProjectStep>, IRepository<ProjectStep>
	{
		public ProjectStepRepository(InMemoryDB db)
			: base(db)
		{ }
	}
}
