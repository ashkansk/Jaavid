using MachineCalculator.UI.Repositories;

namespace MachineCalculator.UI
{
	public static class Factory
	{
		private static InMemoryDB _db = new InMemoryDB();
		private static ProjectRepository _projectRepository;
		private static ProjectStepRepository _projectStepRepository; 
		private static MachineRepository _machineRepository;
		private static MachinePerformanceRepository _machinePerformanceRepository;

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

		internal static ProjectStepRepository GetProjectStepRepository()
		{
			if (_projectStepRepository == null)
				_projectStepRepository = new ProjectStepRepository(GetDB());
			return _projectStepRepository;
		}

		internal static MachineRepository GetMachineRepository()
		{
			if (_machineRepository == null)
				_machineRepository = new MachineRepository(GetDB());
			return _machineRepository;
		}

		internal static MachinePerformanceRepository GetMachinePerformanceRepository()
		{
			if (_machinePerformanceRepository == null)
				_machinePerformanceRepository = new MachinePerformanceRepository(GetDB());
			return _machinePerformanceRepository;
		}

	}
}
