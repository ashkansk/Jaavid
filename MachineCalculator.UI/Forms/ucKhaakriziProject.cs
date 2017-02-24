using System;
using System.Linq;
using System.Windows.Forms;
using MachineCalculator.UI.Repositories;
using MachineCalculator.UI.Entities;
using System.Collections.Generic;

namespace MachineCalculator.UI.Forms
{
	public partial class ucKhaakriziProject : UserControl
	{
		private Project _project;
		private ProjectRepository _projectRepo;
		private ProjectSiteRepository _projectSiteRepo;
		private ProjectStepRepository _projectStepRepo;
		private MachineRepository _machingRepo;
		private double _totalMonthlyWorkHours;
		
		public ucKhaakriziProject(int projectID)
		{
			_projectRepo = Factory.GetProjectRepository();
			_projectSiteRepo = Factory.GetProjectSiteRepository();
			_projectStepRepo = Factory.GetProjectStepRepository();
			_project = _projectRepo.Get(p => p.ID == projectID).SingleOrDefault();
			_machingRepo = Factory.GetMachineRepository();
			if (_project == null)
				throw new ArgumentNullException();
			_project.Sites = _projectSiteRepo.Get(ps => ps.ProjectID == projectID);
			_totalMonthlyWorkHours = _project.ActiveDaysPerMonth * _project.WorkShiftsPerDay * _project.ActiveHoursPerShift;

			InitializeComponent();

		}

		private void SoilTypeButton_Click(object sender, EventArgs e)
		{
			var rdb = sender as RadioButton;
			rdb.Parent.Controls.OfType<GroupBox>().First().Text = rdb.Text;
			if(rdb.Tag != null)
				stepObjBindingSource.DataSource = rdb.Tag;
		}

		private void ucKhaakriziProject_Load(object sender, EventArgs e)
		{
			loadersBindingSource.DataSource = _machingRepo.Get(m => m.Category == "Loader");
			trucksBindingSource.DataSource = _machingRepo.Get(m => m.Category == "Truck");
			dozersBindingSource.DataSource = _machingRepo.Get(m => m.Category == "Dozer");
			rollersBindingSource.DataSource = _machingRepo.Get(m => m.Category == "Roller");

			inclineBindingSource.DataSource = new List<DoubleHelperClass> {
				new DoubleHelperClass { Title="صفر", Value = 0 },
				new DoubleHelperClass { Title="ده", Value = 10 },
				new DoubleHelperClass { Title="بیست", Value = 20 }
			};

			inclineBindingSource.DataSource = new List<DoubleHelperClass> {
				new DoubleHelperClass { Title="70", Value = 70 },
				new DoubleHelperClass { Title="60", Value = 60 },
				new DoubleHelperClass { Title="50", Value = 50 },
				new DoubleHelperClass { Title="40", Value = 40 },
				new DoubleHelperClass { Title="35", Value = 35 },
				new DoubleHelperClass { Title="30", Value = 30 },
				new DoubleHelperClass { Title="25", Value = 25 },
				new DoubleHelperClass { Title="20", Value = 20 },
			};

			// this is to fire the checked change event (to make data binding take effect)
			bool fired = false;
			for (int i = 0; i < _project.Sites.OrderBy(s => s.SoilTypeIndex).Count(); i++)
			{
				ProjectSite site = _project.Sites[i];
				switch ((SoilType)site.SoilTypeIndex)
				{
					case SoilType.SangShekaste:
						rdbSangShekasteStep1.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.SangShekaste, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbSangShekasteStep2.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.SangShekaste, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbSangShekasteStep3.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.SangShekaste, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbSangShekasteStep4.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.SangShekaste, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };

						RunFuncOnRdb(rdb => rdb.Enabled = true, rdbSangShekasteStep1, rdbSangShekasteStep2, rdbSangShekasteStep3, rdbSangShekasteStep4);
						if (!fired)
						{
							RunFuncOnRdb(rdb => rdb.Checked = true, rdbSangShekasteStep1, rdbSangShekasteStep2, rdbSangShekasteStep3, rdbSangShekasteStep4);
							fired = true;
						}
						break;
					case SoilType.ZaminTabiee:
						rdbZaminTabieeStep1.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.ZaminTabiee, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbZaminTabieeStep2.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.ZaminTabiee, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbZaminTabieeStep3.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.ZaminTabiee, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbZaminTabieeStep4.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.ZaminTabiee, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };

						RunFuncOnRdb(rdb => rdb.Enabled = true, rdbZaminTabieeStep1, rdbZaminTabieeStep2, rdbZaminTabieeStep3, rdbZaminTabieeStep4);
						if (!fired)
						{
							RunFuncOnRdb(rdb => rdb.Checked = true, rdbZaminTabieeStep1, rdbZaminTabieeStep2, rdbZaminTabieeStep3, rdbZaminTabieeStep4);
							fired = true;
						}
						break;
					case SoilType.Ros:
						rdbRosStep1.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Ros, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbRosStep2.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Ros, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbRosStep3.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Ros, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbRosStep4.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Ros, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };

						RunFuncOnRdb(rdb => rdb.Enabled = true, rdbRosStep1, rdbRosStep2, rdbRosStep3, rdbRosStep4);
						if (!fired)
						{
							RunFuncOnRdb(rdb => rdb.Checked = true, rdbRosStep1, rdbRosStep2, rdbRosStep3, rdbRosStep4);
							fired = true;
						}
						break;
					case SoilType.Maaseh:
						rdbMaasehStep1.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Maaseh, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbMaasehStep2.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Maaseh, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbMaasehStep3.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Maaseh, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };
						rdbMaasehStep4.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Maaseh, WorkToDo = site.SoilVolume / _totalMonthlyWorkHours };

						RunFuncOnRdb(rdb => rdb.Enabled = true, rdbMaasehStep1, rdbMaasehStep2, rdbMaasehStep3, rdbMaasehStep4);
						if (!fired)
						{
							RunFuncOnRdb(rdb => rdb.Checked = true, rdbMaasehStep1, rdbMaasehStep2, rdbMaasehStep3, rdbMaasehStep4);
							fired = true;
						}
						break;
					default:
						break;
				}
			}
		}

		private void RunFuncOnRdb(Func<RadioButton, object> f, params RadioButton[] rdbList)
		{
			foreach (RadioButton rdb in rdbList)
			{
				f(rdb);
			}
		}

		private void tabCtrlSteps_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			RadioButton selectedSoilRdb = tabCtrlSteps.SelectedTab.Controls.OfType<RadioButton>().Where(rdb => rdb.Checked).First();
			stepObjBindingSource.DataSource = selectedSoilRdb.Tag;
		}
	}
}
