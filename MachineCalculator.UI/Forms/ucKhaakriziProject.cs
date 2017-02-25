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
		private ProjectStepSoilRepository _projectStepRepo;
		private MachineRepository _machingRepo;
		private ucKhaakriziProjectStep[] _ucSteps;
		private int _lastOpenTabPageIndex;

		public ucKhaakriziProject(int projectID)
		{
			_projectRepo = Factory.GetProjectRepository();
			_projectSiteRepo = Factory.GetProjectStepRepository();
			_projectStepRepo = Factory.GetProjectStepSoilRepository();
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
			_ucSteps = new ucKhaakriziProjectStep[]
			{
				new ucKhaakriziProjectStep(_project.Steps[0].ID, "بارگیر", "فاصله حمل", "متر", null),
				new ucKhaakriziProjectStep(_project.Steps[1].ID, "باربر", "فاصله حمل", "کیلومتر", null),
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
			if (e.TabPageIndex < _lastOpenTabPageIndex || (_ucSteps[_lastOpenTabPageIndex].Validate() && e.TabPageIndex == _lastOpenTabPageIndex + 1))
			{
				if(_lastOpenTabPageIndex == 0)
				{
					for (int i = 0; i < _project.Steps.Count; i++)
					{
						if (i == 0)
							continue; // skip step one
									  // else
						ProjectStep step = _project.Steps[i];
						for (int j = (int)SoilType.SangShekaste; j <= (int)SoilType.Maaseh; j++)
						{
							ProjectStepSoil stSoil = step.StepSoils.FirstOrDefault(soil => soil.SoilTypeIndex == j);
							if (stSoil != null)
							{
								ProjectStepSoil originStSoil = _project.Steps[0].StepSoils.First(soil => soil.SoilTypeIndex == j);
								stSoil.WorkToDo = originStSoil.RealRequiredMachineCount * originStSoil.CurrentMachineRealPerformance;
							}
						}
						
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
