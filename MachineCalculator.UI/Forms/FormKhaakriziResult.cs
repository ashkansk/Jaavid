using MachineCalculator.UI.Entities;
using MachineCalculator.UI.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class FormKhaakriziResult : Form
	{
		private ProjectRepository _projectRepo;
		private Project _project;
		private bool _secondTabLoaded;
		public FormKhaakriziResult(int projectID)
		{
			_projectRepo = Factory.GetProjectRepository();
			_project = _projectRepo.Get(p => p.ID == projectID).Single();
			InitializeComponent();
		}

		private void FormKhaakriziResult_Load(object sender, System.EventArgs e)
		{
			txtActiveDaysPerMonth.Text = _project.ActiveDaysPerMonth.ToString();
			txtShiftsPerDay.Text = _project.WorkShiftsPerDay.ToString();
			txtHoursPerShift.Text = _project.HoursPerShift.ToString();
			txtActiveHoursPerShift.Text = _project.ActiveHoursPerShift.ToString();

			ProjectStep step = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baargiri &&
				s.SoilTypeIndex == (int)SoilType.SangShekaste).FirstOrDefault();
			txtSangShekasteSoilVolume.Text = step?.SoilVolume.ToString();
			txtSangShekasteQuantity.Text = step?.TotalDistance.ToString();
			txtSangShekasteRequiredLoader.Text = step?.RequiredMachineCount.ToString("0.##");
			txtSangShekasteRequiredTruck.Text = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baarbari &&
				s.SoilTypeIndex == (int)SoilType.SangShekaste).FirstOrDefault()?.RequiredMachineCount.ToString("0.##");
			txtSangShekasteRealRequiredLoader.Text = step?.RequiredMachineCountReal.ToString();
			txtSangShekasteRealRequiredTruck.Text = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baarbari &&
				s.SoilTypeIndex == (int)SoilType.SangShekaste).FirstOrDefault()?.RequiredMachineCountReal.ToString();

			step = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baargiri &&
				s.SoilTypeIndex == (int)SoilType.ZaminTabiee).FirstOrDefault();
			txtZaminTabieeSoilVolume.Text = step?.SoilVolume.ToString();
			txtZaminTabieeQuantity.Text = step?.TotalDistance.ToString();
			txtZaminTabieeRequiredLoader.Text = step?.RequiredMachineCount.ToString("0.##");
			txtZaminTabieeRequiredTruck.Text = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baarbari &&
				s.SoilTypeIndex == (int)SoilType.ZaminTabiee).FirstOrDefault()?.RequiredMachineCount.ToString("0.##");
			txtZaminTabieeRealRequiredLoader.Text = step?.RequiredMachineCountReal.ToString();
			txtZaminTabieeRealRequiredTruck.Text = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baarbari &&
				s.SoilTypeIndex == (int)SoilType.ZaminTabiee).FirstOrDefault()?.RequiredMachineCountReal.ToString();

			step = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baargiri &&
				s.SoilTypeIndex == (int)SoilType.Ros).FirstOrDefault();
			txtRosSoilVolume.Text = step?.SoilVolume.ToString();
			txtRosQuantity.Text = step?.TotalDistance.ToString();
			txtRosRequiredLoader.Text = step?.RequiredMachineCount.ToString("0.##");
			txtRosRequiredTruck.Text = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baarbari &&
				s.SoilTypeIndex == (int)SoilType.Ros).FirstOrDefault()?.RequiredMachineCount.ToString("0.##");
			txtRosRealRequiredLoader.Text = step?.RequiredMachineCountReal.ToString();
			txtRosRealRequiredTruck.Text = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baarbari &&
				s.SoilTypeIndex == (int)SoilType.Ros).FirstOrDefault()?.RequiredMachineCountReal.ToString();

			step = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baargiri &&
				s.SoilTypeIndex == (int)SoilType.Maaseh).FirstOrDefault();
			txtMaasehSoilVolume.Text = step?.SoilVolume.ToString();
			txtMaasehQuantity.Text = step?.TotalDistance.ToString();
			txtMaasehRequiredLoader.Text = step?.RequiredMachineCount.ToString("0.##");
			txtMaasehRequiredTruck.Text = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baarbari &&
				s.SoilTypeIndex == (int)SoilType.Maaseh).FirstOrDefault()?.RequiredMachineCount.ToString("0.##");
			txtMaasehRealRequiredLoader.Text = step?.RequiredMachineCountReal.ToString();
			txtMaasehRealRequiredTruck.Text = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baarbari &&
				s.SoilTypeIndex == (int)SoilType.Maaseh).FirstOrDefault()?.RequiredMachineCountReal.ToString();

			//Math.Ceiling(_project.Steps.SelectMany(p => p.StepSoils).Where(ss => ss.SoilTypeIndex == (int)SoilType.ZaminTabiee).Sum(ss => ss.RequiredMachineCount)).ToString();

		}

		private void tabCtrlResult_Selecting(object sender, TabControlCancelEventArgs e)
		{
			if (_secondTabLoaded)
				return;
			// else: calculate and load the values
			try
			{
				
				// 1. Loader
				txtLoadingOperatorCount.Text = txtLoaderCATD966Count.Text = _project.Steps.Where(s => 
					s.StepTypeIndex == (int)KhaakriziStepType.Baargiri)
					.Sum(s => s.RequiredMachineCountReal).ToString();
				// 2. Truck
				txtTruckOperatorCount.Text = txtTruckCount.Text = _project.Steps.Where(s => s.StepTypeIndex == (int)KhaakriziStepType.Baarbari)
															.Sum(s => s.RequiredMachineCountReal).ToString();
				// 3. Dozer
				txtDozerTotalCount.Text = _project.Steps.Where(s =>
					s.StepTypeIndex == (int)KhaakriziStepType.Pakhsh)
					.Sum(s => s.RequiredMachineCount).ToString("0.##");
				txtDozerOperatorCount.Text = txtDozerRealCount.Text = Math.Ceiling(Convert.ToDecimal(txtDozerTotalCount.Text)).ToString();
				// 4. Roller
				txtRollerHAMMCount.Text = _project.Steps.Where(s =>
					 s.StepTypeIndex == (int)KhaakriziStepType.Tarakom)
					 .Sum(s => s.RequiredMachineCount).ToString("0.##");
				txtRollerOperatorCount.Text = txtRollerHAMMRealCount.Text = Math.Ceiling(Convert.ToDecimal(txtRollerHAMMCount.Text)).ToString();

				// Project duration
				decimal multiplier = _project.Steps.Where(s =>
					s.StepTypeIndex == (int)KhaakriziStepType.Baargiri)
					.Min(s => s.RequiredMachineCountReal / s.RequiredMachineCount);
				decimal realDurationHours = (decimal)_project.TotalActiveHoursPerMonth / multiplier;
				int days = (int)(realDurationHours / (decimal)(_project.ActiveHoursPerShift * _project.WorkShiftsPerDay));
				decimal remainedHours = realDurationHours - (decimal)(days * _project.ActiveHoursPerShift * _project.WorkShiftsPerDay);
				int hours = (int)remainedHours;
				decimal remainedMinutes = (remainedHours - hours) * 60;
				int minutes = (int)remainedMinutes;
				int seconds = (int)(remainedMinutes - minutes) * 60;

				txtProjectRealDuration.Text = string.Format("{0} روز و {1} ساعت و {2} دقیقه و {3} ثانیه", days, hours, minutes, seconds);
				
				_secondTabLoaded = true;
			}
			catch
			{
				MessageBox.Show("لطفا اطلاعات را به صورت کامل وارد کنید.");
			}
		}
	}
}
