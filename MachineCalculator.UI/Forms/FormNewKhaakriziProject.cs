﻿using MachineCalculator.UI.Entities;
using MachineCalculator.UI.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class FormNewKhaakriziProject : Form
	{
		private SoilRepository _soilRepo;
		private Project _project;
		public Project CreatedProject { get { return _project; } }
		public FormNewKhaakriziProject()
		{
			InitializeComponent();
			_project = new Project();
			_soilRepo = Factory.GetSoilRepository();
		}

		private void FormNewKhaakriziProject_Load(object sender, System.EventArgs e)
		{
			List<Soil> soilList = _soilRepo.Get();

			//cmbSite1.DataSource = soilList;
			//cmbSite2.DataSource = new List<Soil>(soilList);
		}

		private void chkSiteSangShekaste_CheckedChanged(object sender, System.EventArgs e)
		{
			nudSangShekaste.Enabled = chkSiteSangShekaste.Checked;
		}

		private void chkSiteZaminTabiee_CheckedChanged(object sender, System.EventArgs e)
		{
			nudSangShekaste.Enabled = chkSiteSangShekaste.Checked;
		}

		private void chkSiteRos_CheckedChanged(object sender, System.EventArgs e)
		{
			nudSangShekaste.Enabled = chkSiteSangShekaste.Checked;
		}

		private void chkSiteMaaseh_CheckedChanged(object sender, System.EventArgs e)
		{
			nudSangShekaste.Enabled = chkSiteSangShekaste.Checked;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
