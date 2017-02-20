using MachineCalculator.UI.Repositories;
using System;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class FormMain : Form
	{
		UserControl _currentUc;
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
				lblUserGuide.Hide();
				_currentUc = new ucKhaakriziProject
				{
					Dock = DockStyle.Fill,
				};
				grpContainer.Controls.Clear();
				grpContainer.Text = "پروژه خاک‎ریزی";
				grpContainer.Controls.Add(_currentUc);
			}
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}
	}
}
