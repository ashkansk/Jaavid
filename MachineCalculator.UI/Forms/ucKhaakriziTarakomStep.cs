using MachineCalculator.UI.Entities;
using MachineCalculator.UI.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class ucKhaakriziTarakomStep : UserControl, IProjectStepForm
	{
		private ProjectRepository _projectRepo;
		private ProjectStepRepository _projectStepRepo;
		private Project _project;
		private ProjectStep[] _steps;

		public ProjectStep SelectedStep
		{
			get
			{
				return stepObjBindingSource.DataSource as ProjectStep;
			}
		}

		public ucKhaakriziTarakomStep(int projectID)
		{
			_projectRepo = Factory.GetProjectRepository();
			_projectStepRepo = Factory.GetProjectStepRepository();
			_steps = _projectStepRepo.Get(s => s.ProjectID == projectID && s.StepTypeIndex == (int)KhaakriziStepType.Tarakom).ToArray();
			_project = _projectRepo.Get(p => p.ID == projectID).Single();

			InitializeComponent();
		}

		public bool IsValid()
		{
			return true;
		}

		private void ucKhaakriziProjectStep_Load(object sender, EventArgs e)
		{
			// set rdb tags in order to be later used as datasource
			rdbSangShekaste.Tag = _steps.FirstOrDefault(ss => ss.SoilTypeIndex == (int)SoilType.SangShekaste);
			rdbZaminTabiee.Tag = _steps.FirstOrDefault(ss => ss.SoilTypeIndex == (int)SoilType.ZaminTabiee);
			rdbRos.Tag = _steps.FirstOrDefault(ss => ss.SoilTypeIndex == (int)SoilType.Ros);
			rdbMaaseh.Tag = _steps.FirstOrDefault(ss => ss.SoilTypeIndex == (int)SoilType.Maaseh);
			// set disabled or enabled and set checked=true for the first button which is enabled
			RunFuncOnRdb(rdb => rdb.Checked = rdb.Enabled = rdb.Tag != null, rdbMaaseh, rdbRos, rdbZaminTabiee, rdbSangShekaste);


		}
		private void SoilTypeButton_Click(object sender, EventArgs e)
		{
			var rdb = sender as RadioButton;
			grpContainer.Text = rdb.Text;
			if (rdb.Tag != null)
				stepObjBindingSource.DataSource = rdb.Tag;
		}

		private void RunFuncOnRdb(Func<RadioButton, object> f, params RadioButton[] rdbList)
		{
			foreach (RadioButton rdb in rdbList)
			{
				f(rdb);
			}
		}

		/* this method is for validating the step and to check if all the required inputs 
		 * are properly filled with valid data. We don't need validation yet, maybe in near future */

		public bool ValidateStep()
		{
			return true;
		}
	}
}
