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
			/*
			ProjectStepSoil stSoil = _project.Steps[0].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.SangShekaste).FirstOrDefault();
			txtSangShekasteSoilVolume.Text = stSoil?.SoilVolume.ToString();
			txtSangShekasteQuantity.Text = stSoil?.WorkQuantity.ToString();
			txtSangShekasteLoaderType.Text = stSoil?.CurrentMachine?.Title;
			txtSangShekasteTruckType.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.SangShekaste).FirstOrDefault()?.CurrentMachine?.Title;
			txtSangShekasteRequiredLoader.Text = stSoil?.RequiredMachineCount.ToString();
			txtSangShekasteRequiredTruck.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.SangShekaste).FirstOrDefault()?.RequiredMachineCount.ToString();
			txtSangShekasteRealRequiredLoader.Text = stSoil?.RealRequiredMachineCount.ToString();
			txtSangShekasteRealRequiredTruck.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.SangShekaste).FirstOrDefault()?.RealRequiredMachineCount.ToString();

			stSoil = _project.Steps[0].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.ZaminTabiee).FirstOrDefault();
			txtZaminTabieeSoilVolume.Text = stSoil?.SoilVolume.ToString();
			txtZaminTabieeQuantity.Text = stSoil?.WorkQuantity.ToString();
			txtZaminTabieeLoaderType.Text = stSoil?.CurrentMachine?.Title;
			txtZaminTabieeTruckType.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.ZaminTabiee).FirstOrDefault()?.CurrentMachine?.Title;
			txtZaminTabieeRequiredLoader.Text = stSoil?.RequiredMachineCount.ToString();
			txtZaminTabieeRequiredTruck.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.ZaminTabiee).FirstOrDefault()?.RequiredMachineCount.ToString();
			txtZaminTabieeRealRequiredLoader.Text = stSoil?.RealRequiredMachineCount.ToString();
			txtZaminTabieeRealRequiredTruck.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.ZaminTabiee).FirstOrDefault()?.RealRequiredMachineCount.ToString();

			stSoil = _project.Steps[0].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.Ros).FirstOrDefault();
			txtRosSoilVolume.Text = stSoil?.SoilVolume.ToString();
			txtRosQuantity.Text = stSoil?.WorkQuantity.ToString();
			txtRosLoaderType.Text = stSoil?.CurrentMachine?.Title;
			txtRosTruckType.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.Ros).FirstOrDefault()?.CurrentMachine?.Title;
			txtRosRequiredLoader.Text = stSoil?.RequiredMachineCount.ToString();
			txtRosRequiredTruck.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.Ros).FirstOrDefault()?.RequiredMachineCount.ToString();
			txtRosRealRequiredLoader.Text = stSoil?.RealRequiredMachineCount.ToString();
			txtRosRealRequiredTruck.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.Ros).FirstOrDefault()?.RealRequiredMachineCount.ToString();

			stSoil = _project.Steps[0].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.Maaseh).FirstOrDefault();
			txtMaasehSoilVolume.Text = stSoil?.SoilVolume.ToString();
			txtMaasehQuantity.Text = stSoil?.WorkQuantity.ToString();
			txtMaasehLoaderType.Text = stSoil?.CurrentMachine?.Title;
			txtMaasehTruckType.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.Maaseh).FirstOrDefault()?.CurrentMachine?.Title;
			txtMaasehRequiredLoader.Text = stSoil?.RequiredMachineCount.ToString();
			txtMaasehRequiredTruck.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.Maaseh).FirstOrDefault()?.RequiredMachineCount.ToString();
			txtMaasehRealRequiredLoader.Text = stSoil?.RealRequiredMachineCount.ToString();
			txtMaasehRealRequiredTruck.Text = _project.Steps[1].StepSoils.Where(s => s.SoilTypeIndex == (int)SoilType.Maaseh).FirstOrDefault()?.RealRequiredMachineCount.ToString();

			//Math.Ceiling(_project.Steps.SelectMany(p => p.StepSoils).Where(ss => ss.SoilTypeIndex == (int)SoilType.ZaminTabiee).Sum(ss => ss.RequiredMachineCount)).ToString();
			*/
		}

		private void tabCtrlResult_Selecting(object sender, TabControlCancelEventArgs e)
		{
			if (_secondTabLoaded)
				return;
			// else: calculate and load the values
			try
			{
				/*
				// 1. Loader
				txtLoadingOperatorCount.Text = txtLoaderCATD966Count.Text = _project.Steps[0].StepSoils.Sum(soil => soil.RealRequiredMachineCount).ToString();
				// 2. Truck
				txtTruck10TonCount.Text = _project.Steps[1].StepSoils.Where(soil => soil.CurrentMachine.Title == "کامیون 10 تن")
															.Sum(soil => soil.RealRequiredMachineCount).ToString();
				txtTruck12TonCount.Text = _project.Steps[1].StepSoils.Where(soil => soil.CurrentMachine.Title == "کامیون 12 تن")
															.Sum(soil => soil.RealRequiredMachineCount).ToString();
				txtTruckOperatorCount.Text = Convert.ToInt32(txtTruck10TonCount.Text) + Convert.ToInt32(txtTruck12TonCount.Text) + "";
				// 3. Dozer
				txtDozerType.Text = _project.Steps[2].StepSoils.First().CurrentMachine.Title;
				txtDozerTotalCount.Text = _project.Steps[2].StepSoils.Sum(soil => soil.RequiredMachineCount).ToString();
				txtDozerOperatorCount.Text = txtDozerRealCount.Text = Math.Ceiling(Convert.ToDouble(txtDozerTotalCount.Text)).ToString();
				// 4. Roller
				txtRollerHAMMCount.Text = _project.Steps[3].StepSoils.Sum(soil => soil.RequiredMachineCount).ToString();
				txtRollerOperatorCount.Text = txtRollerHAMMRealCount.Text = Math.Ceiling(Convert.ToDouble(txtRollerHAMMCount.Text)).ToString();

				// Project duration
				double multiplier = _project.Steps[0].StepSoils.Min(soil => soil.RealRequiredMachineCount / soil.RequiredMachineCount);
				double realDurationHours = _project.TotalActiveHoursPerMonth / multiplier;
				int days = (int)(realDurationHours / (_project.ActiveHoursPerShift * _project.WorkShiftsPerDay));
				double remainedHours = realDurationHours - (days * _project.ActiveHoursPerShift * _project.WorkShiftsPerDay);
				int hours = (int)remainedHours;
				double remainedMinutes = (remainedHours - hours) * 60;
				int minutes = (int)remainedMinutes;
				int seconds = (int)(remainedMinutes - minutes) * 60;

				txtProjectRealDuration.Text = string.Format("{0} روز و {1} ساعت و {2} دقیقه و {3} ثانیه", days, hours, minutes, seconds);
				*/
				_secondTabLoaded = true;
			}
			catch
			{
				MessageBox.Show("لطفا اطلاعات را به صورت کامل وارد کنید.");
			}
		}
	}
}
