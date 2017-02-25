namespace MachineCalculator.UI.Forms
{
	partial class ucKhaakriziProject
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabpgBaargiri = new System.Windows.Forms.TabPage();
			this.tabCtrlSteps = new System.Windows.Forms.TabControl();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnShowResult = new System.Windows.Forms.Button();
			this.tabCtrlSteps.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(942, 343);
			this.tabPage3.TabIndex = 4;
			this.tabPage3.Text = "تراکم";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(942, 343);
			this.tabPage2.TabIndex = 3;
			this.tabPage2.Text = "پخش";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(942, 343);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "باربری";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabpgBaargiri
			// 
			this.tabpgBaargiri.Location = new System.Drawing.Point(4, 25);
			this.tabpgBaargiri.Name = "tabpgBaargiri";
			this.tabpgBaargiri.Padding = new System.Windows.Forms.Padding(3);
			this.tabpgBaargiri.Size = new System.Drawing.Size(942, 343);
			this.tabpgBaargiri.TabIndex = 1;
			this.tabpgBaargiri.Text = "بارگیری";
			this.tabpgBaargiri.UseVisualStyleBackColor = true;
			// 
			// tabCtrlSteps
			// 
			this.tabCtrlSteps.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tableLayoutPanel1.SetColumnSpan(this.tabCtrlSteps, 2);
			this.tabCtrlSteps.Controls.Add(this.tabpgBaargiri);
			this.tabCtrlSteps.Controls.Add(this.tabPage1);
			this.tabCtrlSteps.Controls.Add(this.tabPage2);
			this.tabCtrlSteps.Controls.Add(this.tabPage3);
			this.tabCtrlSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCtrlSteps.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.tabCtrlSteps.Location = new System.Drawing.Point(3, 3);
			this.tabCtrlSteps.Multiline = true;
			this.tabCtrlSteps.Name = "tabCtrlSteps";
			this.tabCtrlSteps.RightToLeftLayout = true;
			this.tabCtrlSteps.SelectedIndex = 0;
			this.tabCtrlSteps.Size = new System.Drawing.Size(950, 372);
			this.tabCtrlSteps.TabIndex = 0;
			this.tabCtrlSteps.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabCtrlSteps_Selecting);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
			this.tableLayoutPanel1.Controls.Add(this.tabCtrlSteps, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnShowResult, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(956, 414);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// btnShowResult
			// 
			this.btnShowResult.Location = new System.Drawing.Point(39, 381);
			this.btnShowResult.Name = "btnShowResult";
			this.btnShowResult.Size = new System.Drawing.Size(113, 23);
			this.btnShowResult.TabIndex = 1;
			this.btnShowResult.Text = "مشاهده نتایج";
			this.btnShowResult.UseVisualStyleBackColor = true;
			this.btnShowResult.Click += new System.EventHandler(this.btnResult_Click);
			// 
			// ucKhaakriziProject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "ucKhaakriziProject";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(956, 414);
			this.Load += new System.EventHandler(this.ucKhaakriziProject_Load);
			this.tabCtrlSteps.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabpgBaargiri;
		private System.Windows.Forms.TabControl tabCtrlSteps;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnShowResult;
	}
}
