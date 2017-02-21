﻿using MachineCalculator.UI.Entities;
using MachineCalculator.UI.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class FormNewKhaakriziProject : Form
	{
		private ProjectRepository _projectRepo;
		private ProjectSiteRepository _projectSiteRepo;
		private Project _project;
		public int CreatedProjectID { get { return _project.ID; } }
		public FormNewKhaakriziProject()
		{
			InitializeComponent();
			_projectRepo = Factory.GetProjectRepository();
			_projectSiteRepo = Factory.GetProjectSiteRepository();
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
				HoursPerDay = (int)nudDailyHours.Value,
				ActiveHoursPerDay = (int)nudDailyActiveHours.Value,
				WorkShiftsPerDay = (int)nudDailyShifts.Value,
			};
			_projectRepo.Insert(_project);
			if(chkSiteSangShekaste.Checked)
				_projectSiteRepo.Insert(new ProjectSite
				{
					ProjectID = _project.ID,
					SoilTypeIndex = (int)SoilType.SangShekaste,
					SoilVolume = (int)nudSangShekaste.Value
				});

			if (chkSiteZaminTabiee.Checked)
				_projectSiteRepo.Insert(new ProjectSite
				{
					ProjectID = _project.ID,
					SoilTypeIndex = (int)SoilType.ZaminTabiee,
					SoilVolume = (int)nudZaminTabiee.Value
				});

			if (chkSiteRos.Checked)
				_projectSiteRepo.Insert(new ProjectSite
				{
					ProjectID = _project.ID,
					SoilTypeIndex = (int)SoilType.Ros,
					SoilVolume = (int)nudRos.Value
				});

			if (chkSiteMaaseh.Checked)
				_projectSiteRepo.Insert(new ProjectSite
				{
					ProjectID = _project.ID,
					SoilTypeIndex = (int)SoilType.Maaseh,
					SoilVolume = (int)nudMaaseh.Value
				});


			this.Close();
			this.DialogResult = DialogResult.OK;
		}
	}
}
