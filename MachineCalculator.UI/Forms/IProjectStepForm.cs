using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Forms
{
	public interface IProjectStepForm
	{
		ProjectStep SelectedStep { get; }
		/* this method is for validating the step and to check if all the required inputs 
		 * are properly filled with valid data. We don't need validation yet, maybe in near future */
		bool ValidateStep();
	}
}
