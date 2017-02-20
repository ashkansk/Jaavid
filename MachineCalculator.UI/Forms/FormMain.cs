using MachineCalculator.UI.Repositories;
using System;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void mItemKhaakriziProject_Click(object sender, EventArgs e)
		{
			var newForm = new FormNewKhaakriziProject();
			DialogResult result = newForm.ShowDialog();
			if(result == DialogResult.OK)
			{

			}
		}
	}
}
