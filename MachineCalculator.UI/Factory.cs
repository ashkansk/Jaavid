using MachineCalculator.UI.Repositories;

namespace MachineCalculator.UI
{
	public static class Factory
	{
		private static InMemoryDB _db = new InMemoryDB();
		private static ProjectRepository _projectRepository;
		private static ProjectSiteRepository _projectSiteRepository; 
		private static ProjectStepRepository _projectStepRepository;
		private static SoilRepository _soilRepository;
		private static MachineRepository _machineRepository;
		internal static InMemoryDB GetDB()
		{
			if (_db == null)
				_db = new InMemoryDB();
			return _db;
		}

		internal static ProjectRepository GetProjectRepository()
		{
			if (_projectRepository == null)
				_projectRepository = new ProjectRepository(GetDB());
			return _projectRepository;
		}

		internal static ProjectSiteRepository GetProjectSiteRepository()
		{
			if (_projectSiteRepository == null)
				_projectSiteRepository = new ProjectSiteRepository(GetDB());
			return _projectSiteRepository;
		}

		internal static ProjectStepRepository GetProjectStepRepository()
		{
			if (_projectStepRepository == null)
				_projectStepRepository = new ProjectStepRepository(GetDB());
			return _projectStepRepository;
		}

		internal static SoilRepository GetSoilRepository()
		{
			if (_soilRepository == null)
				_soilRepository = new SoilRepository(GetDB());
			return _soilRepository;
		}

		internal static MachineRepository GetMachineRepository()
		{
			if (_machineRepository == null)
				_machineRepository = new MachineRepository(GetDB());
			return _machineRepository;
		}


	}
}
