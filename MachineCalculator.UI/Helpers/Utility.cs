namespace MachineCalculator.UI.Helpers
{
	public static class Utility
	{
		public static string GetMachineCategoryByKhaakriziStepType(KhaakriziStepType stepType)
		{
			switch (stepType)
			{
				case KhaakriziStepType.Baargiri:
					return "Loader";
				case KhaakriziStepType.Baarbari:
					return "Truck";
				case KhaakriziStepType.Pakhsh:
					return "Dozer";
				case KhaakriziStepType.Tarakom:
					return "Roller";
				default:
					return "";
			}
		}
	}
}
