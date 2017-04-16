using System;
using System.Linq;
using System.Windows.Forms;
using MachineCalculator.UI.Repositories;
using MachineCalculator.UI.Entities;

namespace MachineCalculator.UI.Forms
{
	public partial class ucKhaakriziProject : UserControl
	{
		private Project _project;
		private ProjectRepository _projectRepo;
		private ProjectStepRepository _projectSiteRepo;
		private MachineRepository _machingRepo;
		private UserControl[] _ucSteps;
		private int _lastOpenTabPageIndex;

		public ucKhaakriziProject(int projectID)
		{
			_projectRepo = Factory.GetProjectRepository();
			_projectSiteRepo = Factory.GetProjectStepRepository();
			_project = _projectRepo.Get(p => p.ID == projectID).SingleOrDefault();
			_machingRepo = Factory.GetMachineRepository();
			if (_project == null)
				throw new ArgumentNullException();
			_project.Steps = _projectSiteRepo.Get(ps => ps.ProjectID == projectID);

			InitializeComponent();
		}

		private void ucKhaakriziProject_Load(object sender, EventArgs e)
		{
			_lastOpenTabPageIndex = 0;
			_ucSteps = new UserControl[]
			{
				new ucKhaakriziBaargiriStep(_project.ID),
				new ucKhaakriziBaabariStep(_project.ID),
				new ucKhaakriziProjectStep(_project.Steps[2].ID, "بولدوزر", "فاصله حمل", "متر", "شیب"),
				new ucKhaakriziProjectStep(_project.Steps[3].ID, "غلطک", "تعداد پاس عبوری", "", "ضخامت لایه"),
			};
			for (int i = 0; i < _ucSteps.Length; i++)
			{
				_ucSteps[i].Dock = DockStyle.Fill;
				tabCtrlSteps.TabPages[i].Controls.Add(_ucSteps[i]);
			}
		}

		private void RunFuncOnRdb(Func<RadioButton, object> f, params RadioButton[] rdbList)
		{
			foreach (RadioButton rdb in rdbList)
			{
				f(rdb);
			}
		}

		private void tabCtrlSteps_Selecting(object sender, TabControlCancelEventArgs e)
		{
			if (_ucSteps[_lastOpenTabPageIndex].Validate())
			{
				if(_lastOpenTabPageIndex == 0) // all steps are dependent on step 0, so when leaving step 0, we update all other steps' values
				{
					foreach (ProjectStep step in _project.Steps)
					{
						if (step.StepTypeIndex == (int)KhaakriziStepType.Baargiri)
							continue; // skip step one
						// else
						ProjectStep stepOne = _project.Steps.FirstOrDefault(s => 
						s.StepTypeIndex == (int)KhaakriziStepType.Baargiri && s.SoilTypeIndex == step.SoilTypeIndex);
						step.WorkToDo = stepOne.RequiredMachineCountReal * stepOne.MachinePowerReal; // calculate "WorkToDo" for other step
						if (step.StepIndex == (int)KhaakriziStepType.Baarbari)
							step.CustomParam2 = stepOne.MachinePower;
					}
				}
				_lastOpenTabPageIndex = e.TabPageIndex; // move on to next page (or previous pages)
			}
			else
				e.Cancel = true;
		}

		private void btnResult_Click(object sender, EventArgs e)
		{
			var form = new FormKhaakriziResult(_project.ID);
			form.ShowDialog();
		}
	}
}
