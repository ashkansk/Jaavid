using MachineCalculator.UI.Entities;
using MachineCalculator.UI.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class FormNewKhaakriziProject : Form
	{
		private ProjectRepository _projectRepo;
		private ProjectStepRepository _projectStepRepo;
		private Project _project;
		private Dictionary<SoilType, CheckBox> _mapSoilTypeCheckBox;
		public int CreatedProjectID { get { return _project.ID; } }
		public FormNewKhaakriziProject()
		{
			InitializeComponent();

			_projectRepo = Factory.GetProjectRepository();
			_projectStepRepo = Factory.GetProjectStepRepository();
			_mapSoilTypeCheckBox = new Dictionary<SoilType, CheckBox>
			{
				{ SoilType.SangShekaste, chkSiteSangShekaste },
				{ SoilType.ZaminTabiee, chkSiteZaminTabiee },
				{ SoilType.Ros, chkSiteRos },
				{ SoilType.Maaseh, chkSiteMaaseh }
			};
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

			_project.Steps = new List<ProjectStep>();

			// create steps for each type of soil (if checked), but only the first step needs work to do, the next steps' work to do are calcualted

			foreach (var soilAndCheckBox in _mapSoilTypeCheckBox)
			{
				if (soilAndCheckBox.Value.Checked)
					_project.Steps.AddRange(new List<ProjectStep>
					{
						new KhaakriziBaargiriStep
						{
							StepIndex =(int)KhaakriziStepType.Baargiri,
							StepTypeIndex =(int)KhaakriziStepType.Baargiri,
							SoilTypeIndex = (int)soilAndCheckBox.Key,
							SoilVolume = (int)nudSangShekaste.Value
						},
						new KhaakriziBaarbariStep
						{
							StepIndex =(int)KhaakriziStepType.Baarbari,
							StepTypeIndex =(int)KhaakriziStepType.Baarbari,
							SoilTypeIndex = (int)soilAndCheckBox.Key,
							SoilVolume = (int)nudSangShekaste.Value
						},
						new KhaakriziPakhshStep
						{
							StepIndex =(int)KhaakriziStepType.Pakhsh,
							StepTypeIndex =(int)KhaakriziStepType.Pakhsh,
							SoilTypeIndex = (int)soilAndCheckBox.Key,
							SoilVolume = (int)nudSangShekaste.Value
						},
						new KhaakriziTarakomStep
						{
							StepIndex =(int)KhaakriziStepType.Tarakom,
							StepTypeIndex =(int)KhaakriziStepType.Tarakom,
							SoilTypeIndex = (int)soilAndCheckBox.Key,
							SoilVolume = (int)nudSangShekaste.Value
						},
					});
			}

			try
			{
				// validation
				if (_project.ActiveDaysPerMonth <= 0 || _project.WorkShiftsPerDay <= 0 || _project.ActiveHoursPerShift <= 0)
					ShowValidationError();
				if (_project.ActiveHoursPerShift > _project.HoursPerShift)
					ShowValidationError();

				foreach (ProjectStep step in _project.Steps)
					if (step.SoilVolume <= 0)
						ShowValidationError();
				// end validation

				// insert objects into db
				_projectRepo.Insert(_project);
				foreach (ProjectStep step in _project.Steps)
				{
					step.MachineEfficiency = (decimal)_project.ActiveHoursPerShift / (decimal)_project.HoursPerShift;
					step.ProjectID = _project.ID;
					_projectStepRepo.Insert(step);
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
