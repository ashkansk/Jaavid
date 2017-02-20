using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Repositories
{
	public class ProjectSiteRepository : RepositoryBase<ProjectSite>, IRepository<ProjectSite>
	{
		public ProjectSiteRepository(InMemoryDB db)
			: base(db)
		{ }
	}
}
