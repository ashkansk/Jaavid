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
			doubleHelperClassBindingSource.DataSource = new List<DoubleHelperClass> {
				new DoubleHelperClass { Title="صفر", Value = 0 },
				new DoubleHelperClass { Title="ده", Value = 10 },
				new DoubleHelperClass { Title="بیست", Value = 20 }
			};

			// this is to fire the checked change event (to make data binding take effect)
			bool fired = false;
			for (int i = 0; i < _project.Sites.OrderBy(s => s.SoilTypeIndex).Count(); i++)
			{
				ProjectSite site = _project.Sites[i];
				switch ((SoilType)site.SoilTypeIndex)
				{
					case SoilType.SangShekaste:
						rdbSangShekasteStep1.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.SangShekaste, WorkToDo = site.SoilVolume };
						rdbSangShekasteStep2.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.SangShekaste, WorkToDo = site.SoilVolume };
						rdbSangShekasteStep3.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.SangShekaste, WorkToDo = site.SoilVolume };
						rdbSangShekasteStep4.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.SangShekaste, WorkToDo = site.SoilVolume };

						RunFuncOnRdb(rdb => rdb.Enabled = true, rdbSangShekasteStep1, rdbSangShekasteStep2, rdbSangShekasteStep3, rdbSangShekasteStep4);
						if (!fired)
						{
							RunFuncOnRdb(rdb => rdb.Checked = true, rdbSangShekasteStep1, rdbSangShekasteStep2, rdbSangShekasteStep3, rdbSangShekasteStep4);
							fired = true;
						}
						break;
					case SoilType.ZaminTabiee:
						rdbZaminTabieeStep1.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.ZaminTabiee, WorkToDo = site.SoilVolume };
						rdbZaminTabieeStep2.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.ZaminTabiee, WorkToDo = site.SoilVolume };
						rdbZaminTabieeStep3.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.ZaminTabiee, WorkToDo = site.SoilVolume };
						rdbZaminTabieeStep4.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.ZaminTabiee, WorkToDo = site.SoilVolume };

						RunFuncOnRdb(rdb => rdb.Enabled = true, rdbZaminTabieeStep1, rdbZaminTabieeStep2, rdbZaminTabieeStep3, rdbZaminTabieeStep4);
						if (!fired)
						{
							RunFuncOnRdb(rdb => rdb.Checked = true, rdbZaminTabieeStep1, rdbZaminTabieeStep2, rdbZaminTabieeStep3, rdbZaminTabieeStep4);
							fired = true;
						}
						break;
					case SoilType.Ros:
						rdbRosStep1.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Ros, WorkToDo = site.SoilVolume };
						rdbRosStep2.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Ros, WorkToDo = site.SoilVolume };
						rdbRosStep3.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Ros, WorkToDo = site.SoilVolume };
						rdbRosStep4.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Ros, WorkToDo = site.SoilVolume };

						RunFuncOnRdb(rdb => rdb.Enabled = true, rdbRosStep1, rdbRosStep2, rdbRosStep3, rdbRosStep4);
						if (!fired)
						{
							RunFuncOnRdb(rdb => rdb.Checked = true, rdbRosStep1, rdbRosStep2, rdbRosStep3, rdbRosStep4);
							fired = true;
						}
						break;
					case SoilType.Maaseh:
						rdbMaasehStep1.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Maaseh, WorkToDo = site.SoilVolume };
						rdbMaasehStep2.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Maaseh, WorkToDo = site.SoilVolume };
						rdbMaasehStep3.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Maaseh, WorkToDo = site.SoilVolume };
						rdbMaasehStep4.Tag = new ProjectStep { ProjectSiteID = site.ID, StepTypeIndex = (int)SoilType.Maaseh, WorkToDo = site.SoilVolume };

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

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var step = stepObjBindingSource.DataSource as ProjectStep;
			double factor = step.EnvironmentFactor;
			MessageBox.Show(factor.ToString());
		}
	}
}
