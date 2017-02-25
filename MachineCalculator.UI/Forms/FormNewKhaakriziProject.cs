using MachineCalculator.UI.Entities;
using MachineCalculator.UI.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class FormNewKhaakriziProject : Form
	{
		private ProjectRepository _projectRepo;
		private ProjectStepRepository _projectStepRepo;
		private ProjectStepSoilRepository _projectStepSoilRepo;
		private Project _project;
		public int CreatedProjectID { get { return _project.ID; } }
		public FormNewKhaakriziProject()
		{
			InitializeComponent();
			_projectRepo = Factory.GetProjectRepository();
			_projectStepRepo = Factory.GetProjectStepRepository();
			_projectStepSoilRepo = Factory.GetProjectStepSoilRepository();
		}

		private void FormNewKhaakriziProject_Load(object sender, System.EventArgs e)
		{
		}

		private void chkSiteSangShekaste_CheckedChanged(object sender, System.EventArgs e)
		{
			nudSangShekaste.Enabled = chkSiteSangShekaste.Checked;
		}

		private void chkSiteZaminTabiee_CheckedChanged(object sender, System.EventArgs e)
		{
			nudZaminTabiee.Enabled = chkSiteZaminTabiee.Checked;
		}

		private void chkSiteRos_CheckedChanged(object sender, System.EventArgs e)
		{
			nudRos.Enabled = chkSiteRos.Checked;
		}

		private void chkSiteMaaseh_CheckedChanged(object sender, System.EventArgs e)
		{
			nudMaaseh.Enabled = chkSiteMaaseh.Checked;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			_project = new Project
			{
				ActiveDaysPerMonth = (int)nudActiveDaysInMonth.Value,
				WorkShiftsPerDay = (int)nudDailyShifts.Value,
				HoursPerShift = (double)nudDailyHours.Value,
				ActiveHoursPerShift = (double)nudDailyActiveHours.Value,
			};

			_project.Steps = new List<ProjectStep>
			{
				new ProjectStep {StepIndex=(int)KhaakriziStepType.Baargiri, StepTypeIndex=(int)KhaakriziStepType.Baargiri },
				new ProjectStep {StepIndex=(int)KhaakriziStepType.Baarbari, StepTypeIndex=(int)KhaakriziStepType.Baarbari },
				new ProjectStep {StepIndex=(int)KhaakriziStepType.Pakhsh, StepTypeIndex=(int)KhaakriziStepType.Pakhsh },
				new ProjectStep {StepIndex=(int)KhaakriziStepType.Tarakom, StepTypeIndex=(int)KhaakriziStepType.Tarakom },
			};

			// create steps' soil, but only the first step needs work to do, the next steps' work to do are calcualted
			if (chkSiteSangShekaste.Checked)
				foreach (ProjectStep step in _project.Steps)
					step.StepSoils.Add(new ProjectStepSoil
					{
						SoilTypeIndex = (int)SoilType.SangShekaste,
						SoilVolume = (int)nudSangShekaste.Value
					});


			if (chkSiteZaminTabiee.Checked)
				foreach (ProjectStep step in _project.Steps)
					step.StepSoils.Add(new ProjectStepSoil
					{
						SoilTypeIndex = (int)SoilType.ZaminTabiee,
						SoilVolume = (int)nudZaminTabiee.Value
					});

			if (chkSiteRos.Checked)
				foreach (ProjectStep step in _project.Steps)
					step.StepSoils.Add(new ProjectStepSoil
					{
						SoilTypeIndex = (int)SoilType.Ros,
						SoilVolume = (int)nudRos.Value
					});

			if (chkSiteMaaseh.Checked)
				foreach (ProjectStep step in _project.Steps)
					step.StepSoils.Add(new ProjectStepSoil
					{
						SoilTypeIndex = (int)SoilType.Maaseh,
						SoilVolume = (int)nudMaaseh.Value
					});

			try
			{
				// validation
				if (_project.ActiveDaysPerMonth <= 0 || _project.WorkShiftsPerDay <= 0 || _project.ActiveHoursPerShift <= 0)
					ShowValidationError();
				if (_project.ActiveHoursPerShift > _project.HoursPerShift)
					ShowValidationError();
			
					foreach (ProjectStepSoil stSoil in _project.Steps[0].StepSoils)
						if (stSoil.SoilVolume <= 0)
							ShowValidationError();			
				// end validation

				// insert objects into db
				_projectRepo.Insert(_project);
				foreach (ProjectStep step in _project.Steps)
				{
					step.ProjectID = _project.ID;
					_projectStepRepo.Insert(step);
					foreach (ProjectStepSoil stSoil in step.StepSoils)
					{
						stSoil.StepID = step.ID;
						_projectStepSoilRepo.Insert(stSoil);
					}
				}

				this.Close();
				this.DialogResult = DialogResult.OK;
			}
			catch
			{
				_project = null;
			}

		}

		private void ShowValidationError(bool silent = false)
		{
			MessageBox.Show("اطلاعات وارد شده نامعتبر است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			throw new System.Exception();
		}
	}
}
