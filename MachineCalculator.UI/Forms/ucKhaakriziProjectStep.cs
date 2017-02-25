using MachineCalculator.UI.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class ucKhaakriziProjectStep : UserControl
	{
		public ucKhaakriziProjectStep(string machineName, string workMetricUnit, string envFactorLabel, ProjectStep)
		{
			InitializeComponent();
		}

		private void SoilTypeButton_Click(object sender, EventArgs e)
		{
			var rdb = sender as RadioButton;
			rdb.Parent.Controls.OfType<GroupBox>().First().Text = rdb.Text;
			if (rdb.Tag != null)
				stepObjBindingSource.DataSource = rdb.Tag;
		}
	}
}
