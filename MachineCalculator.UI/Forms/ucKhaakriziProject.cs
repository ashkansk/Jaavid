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


		}

		private void ucKhaakriziProject_Load(object sender, EventArgs e)
		{
			// this is to fire the checked change event (to make data binding take effect)
			rdbSangShekasteStep1.Checked = true;
			rdbSangShekasteStep2.Checked = true;
			rdbSangShekasteStep3.Checked = true;
			rdbSangShekasteStep4.Checked = true;

			cmbLoaderType.DataSource = _machingRepo.Get(m => m.Category == "Loader");
			cmbTruckType.DataSource = _machingRepo.Get(m => m.Category == "Truck");
			cmbDozerType.DataSource = _machingRepo.Get(m => m.Category == "Dozer");
			cmbRollerType.DataSource = _machingRepo.Get(m => m.Category == "Roller");
		}
	}
}
