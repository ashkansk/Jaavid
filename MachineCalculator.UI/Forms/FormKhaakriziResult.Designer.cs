namespace MachineCalculator.UI.Forms
{
	partial class FormKhaakriziResult
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabCtrlResult = new System.Windows.Forms.TabControl();
			this.tabpgBasedOnSoilType = new System.Windows.Forms.TabPage();
			this.tabpgBasedOnStepTypes = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tabCtrlResult.SuspendLayout();
			this.tabpgBasedOnSoilType.SuspendLayout();
			this.tabpgBasedOnStepTypes.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabCtrlResult
			// 
			this.tabCtrlResult.Controls.Add(this.tabpgBasedOnSoilType);
			this.tabCtrlResult.Controls.Add(this.tabpgBasedOnStepTypes);
			this.tabCtrlResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCtrlResult.Location = new System.Drawing.Point(0, 0);
			this.tabCtrlResult.Name = "tabCtrlResult";
			this.tabCtrlResult.RightToLeftLayout = true;
			this.tabCtrlResult.SelectedIndex = 0;
			this.tabCtrlResult.Size = new System.Drawing.Size(722, 795);
			this.tabCtrlResult.TabIndex = 0;
			// 
			// tabpgBasedOnSoilType
			// 
			this.tabpgBasedOnSoilType.Controls.Add(this.tableLayoutPanel1);
			this.tabpgBasedOnSoilType.Location = new System.Drawing.Point(4, 22);
			this.tabpgBasedOnSoilType.Name = "tabpgBasedOnSoilType";
			this.tabpgBasedOnSoilType.Padding = new System.Windows.Forms.Padding(3);
			this.tabpgBasedOnSoilType.Size = new System.Drawing.Size(714, 769);
			this.tabpgBasedOnSoilType.TabIndex = 0;
			this.tabpgBasedOnSoilType.Text = "تفکیک بر اساس نوع خاک";
			this.tabpgBasedOnSoilType.UseVisualStyleBackColor = true;
			// 
			// tabpgBasedOnStepTypes
			// 
			this.tabpgBasedOnStepTypes.Controls.Add(this.tableLayoutPanel2);
			this.tabpgBasedOnStepTypes.Location = new System.Drawing.Point(4, 22);
			this.tabpgBasedOnStepTypes.Name = "tabpgBasedOnStepTypes";
			this.tabpgBasedOnStepTypes.Padding = new System.Windows.Forms.Padding(3);
			this.tabpgBasedOnStepTypes.Size = new System.Drawing.Size(714, 769);
			this.tabpgBasedOnStepTypes.TabIndex = 1;
			this.tabpgBasedOnStepTypes.Text = "تفکیک بر اساس مراحل";
			this.tabpgBasedOnStepTypes.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 763);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(708, 763);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// FormKhaakriziResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 795);
			this.Controls.Add(this.tabCtrlResult);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FormKhaakriziResult";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.Text = "پروژه خاکریزی - نتیجه";
			this.tabCtrlResult.ResumeLayout(false);
			this.tabpgBasedOnSoilType.ResumeLayout(false);
			this.tabpgBasedOnStepTypes.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCtrlResult;
		private System.Windows.Forms.TabPage tabpgBasedOnSoilType;
		private System.Windows.Forms.TabPage tabpgBasedOnStepTypes;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}