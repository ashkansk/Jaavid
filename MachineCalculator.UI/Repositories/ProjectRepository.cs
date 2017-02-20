using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Repositories
{
	public class ProjectRepository : RepositoryBase<Project>, IRepository<Project>
	{
		public ProjectRepository(InMemoryDB db)
			: base(db)
		{ }

	}
}
