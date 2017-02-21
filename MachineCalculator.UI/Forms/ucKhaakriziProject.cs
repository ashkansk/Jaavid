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
		private MachineRepository _machingRepo;
		private ProjectStep _step = new ProjectStep();
		public ucKhaakriziProject(int projectID)
		{
			_projectRepo = Factory.GetProjectRepository();
			_projectSiteRepo = Factory.GetProjectSiteRepository();
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

			projectStepBindingSource.DataSource = _step;
		}

		private void ucKhaakriziProject_Load(object sender, EventArgs e)
		{

			loadersBindingSource.DataSource = _machingRepo.Get(m => m.Category == "Loader");
			trucksBindingSource.DataSource = _machingRepo.Get(m => m.Category == "Truck");
			dozersBindingSource.DataSource = _machingRepo.Get(m => m.Category == "Dozer");
			rollersBindingSource.DataSource = _machingRepo.Get(m => m.Category == "Roller");

			// this is to fire the checked change event (to make data binding take effect)
			bool fired = false;
			for (int i = 0; i < _project.Sites.OrderBy(s => s.SoilTypeIndex).Count(); i++)
			{
				switch ((SoilType)_project.Sites[i].SoilTypeIndex)
				{
					case SoilType.SangShekaste:
						RunFuncOnRdb(rdb => rdb.Enabled = true, rdbSangShekasteStep1, rdbSangShekasteStep2, rdbSangShekasteStep3, rdbSangShekasteStep4);
						if (!fired)
						{
							RunFuncOnRdb(rdb => rdb.Checked = true, rdbSangShekasteStep1, rdbSangShekasteStep2, rdbSangShekasteStep3, rdbSangShekasteStep4);
							fired = true;
						}
						break;
					case SoilType.ZaminTabiee:
						RunFuncOnRdb(rdb => rdb.Enabled = true, rdbZaminTabieeStep1, rdbZaminTabieeStep2, rdbZaminTabieeStep3, rdbZaminTabieeStep4);
						if (!fired)
						{
							RunFuncOnRdb(rdb => rdb.Checked = true, rdbZaminTabieeStep1, rdbZaminTabieeStep2, rdbZaminTabieeStep3, rdbZaminTabieeStep4);
							fired = true;
						}
						break;
					case SoilType.Ros:
						RunFuncOnRdb(rdb => rdb.Enabled = true, rdbRosStep1, rdbRosStep2, rdbRosStep3, rdbRosStep4);
						if (!fired)
						{
							RunFuncOnRdb(rdb => rdb.Checked = true, rdbRosStep1, rdbRosStep2, rdbRosStep3, rdbRosStep4);
							fired = true;
						}
						break;
					case SoilType.Maaseh:
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
	}
}
