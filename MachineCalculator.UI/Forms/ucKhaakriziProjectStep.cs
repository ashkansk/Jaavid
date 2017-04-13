using MachineCalculator.UI.Entities;
using MachineCalculator.UI.Helpers;
using MachineCalculator.UI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class ucKhaakriziProjectStep : UserControl
	{
		private MachineRepository _machingRepo;
		private ProjectRepository _projectRepo;
		private ProjectStepRepository _projectStepRepo;
		private Project _project;
		private ProjectStep _step;
		private CaptionHelper _captionHelperObj;

		public ucKhaakriziProjectStep(int stepID, string machineName, string workQuantityLabel, string workMetricUnit, string envFactorLabel)
		{
			_projectRepo = Factory.GetProjectRepository();
			_projectStepRepo = Factory.GetProjectStepRepository();
			_machingRepo = Factory.GetMachineRepository();
			_step = _projectStepRepo.Get(s => s.ID == stepID).Single();
			_project = _projectRepo.Get(p => p.ID == _step.ProjectID).Single();
			_captionHelperObj = new CaptionHelper { MachineName = machineName, WorkQuantityLabel = workQuantityLabel, WorkMetricUnit = workMetricUnit, EnvFactorLabel = envFactorLabel };

			InitializeComponent();

			if (envFactorLabel == null)
				lblEnvFactor.Visible = cmbEnvFactor.Visible = false;
		}

		public bool IsValid()
		{
			return true;
		}

		private void ucKhaakriziProjectStep_Load(object sender, EventArgs e)
		{
			/*
			if(_step.StepTypeIndex == (int)KhaakriziStepType.Baargiri)
				foreach (ProjectStepSoil stSoil in _step.StepSoils)
					stSoil.WorkToDo = stSoil.SoilVolume / _project.TotalActiveHoursPerMonth;

			captionHelperBindingSource.DataSource = _captionHelperObj;

			string machineCat = Utility.GetMachineCategoryByKhaakriziStepType((KhaakriziStepType)_step.StepTypeIndex);
			machineBindingSource.DataSource = _machingRepo.Get(m => m.Category == machineCat);

			if (_step.StepTypeIndex == (int)KhaakriziStepType.Pakhsh)
				envFactorBindingSource.DataSource = new List<DoubleHelperClass> {
					new DoubleHelperClass { Title="صفر درصد", Value = 0 },
					new DoubleHelperClass { Title="ده درصد", Value = 10 },
					new DoubleHelperClass { Title="بیست درصد", Value = 20 }
				};
			else if(_step.StepTypeIndex == (int)KhaakriziStepType.Tarakom)
				envFactorBindingSource.DataSource = new List<DoubleHelperClass> {
					new DoubleHelperClass { Title="70 سانتی متر", Value = 70 },
					new DoubleHelperClass { Title="60 سانتی متر", Value = 60 },
					new DoubleHelperClass { Title="50 سانتی متر", Value = 50 },
					new DoubleHelperClass { Title="40 سانتی متر", Value = 40 },
					new DoubleHelperClass { Title="35 سانتی متر", Value = 35 },
					new DoubleHelperClass { Title="30 سانتی متر", Value = 30 },
					new DoubleHelperClass { Title="25 سانتی متر", Value = 25 },
					new DoubleHelperClass { Title="20 سانتی متر", Value = 20 },
				};

			// set rdb tags to be used as datasource
			rdbSangShekaste.Tag = _step.StepSoils.FirstOrDefault(ss => ss.SoilTypeIndex == (int)SoilType.SangShekaste);
			rdbZaminTabiee.Tag = _step.StepSoils.FirstOrDefault(ss => ss.SoilTypeIndex == (int)SoilType.ZaminTabiee);
			rdbRos.Tag = _step.StepSoils.FirstOrDefault(ss => ss.SoilTypeIndex == (int)SoilType.Ros);
			rdbMaaseh.Tag = _step.StepSoils.FirstOrDefault(ss => ss.SoilTypeIndex == (int)SoilType.Maaseh);
			// set disabled or enabled and set checked=true for the first button which is enabled
			RunFuncOnRdb(rdb => rdb.Checked = rdb.Enabled = rdb.Tag != null, rdbMaaseh, rdbRos, rdbZaminTabiee, rdbSangShekaste);

	*/
		}
		private void SoilTypeButton_Click(object sender, EventArgs e)
		{
			var rdb = sender as RadioButton;
			grpContainer.Text = rdb.Text;
			if (rdb.Tag != null)
				stepSoilObjBindingSource.DataSource = rdb.Tag;
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
