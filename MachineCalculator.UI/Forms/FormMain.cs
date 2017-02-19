using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineCalculator.UI.Forms
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void mItemNew_Click(object sender, EventArgs e)
		{
			FormNewProject frm = new FormNewProject();
			frm.ShowDialog();
		}
	}
}
