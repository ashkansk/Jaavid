using MachineCalculator.UI.Repositories;

namespace MachineCalculator.UI
{
	public static class Factory
	{
		private static InMemoryDB _db = new InMemoryDB();
		private static SoilRepository _soilRepository;
		internal static InMemoryDB GetDB()
		{
			if (_db == null)
				_db = new InMemoryDB();
			return _db;
		}

		internal static SoilRepository GetSoilRepository()
		{
			if (_soilRepository == null)
				_soilRepository = new SoilRepository(GetDB());
			return _soilRepository;
		}



	}
}
