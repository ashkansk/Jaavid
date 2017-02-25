namespace MachineCalculator.UI.Forms
{
	partial class FormNewKhaakriziProject
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
			this.nudDailyShifts = new System.Windows.Forms.NumericUpDown();
			this.nudDailyActiveHours = new System.Windows.Forms.NumericUpDown();
			this.lblDivider1 = new System.Windows.Forms.Label();
			this.chkSiteMaaseh = new System.Windows.Forms.CheckBox();
			this.chkSiteRos = new System.Windows.Forms.CheckBox();
			this.chkSiteZaminTabiee = new System.Windows.Forms.CheckBox();
			this.chkSiteSangShekaste = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nudActiveDaysInMonth = new System.Windows.Forms.NumericUpDown();
			this.nudDailyHours = new System.Windows.Forms.NumericUpDown();
			this.nudSangShekaste = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.nudZaminTabiee = new System.Windows.Forms.NumericUpDown();
			this.nudRos = new System.Windows.Forms.NumericUpDown();
			this.nudMaaseh = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudDailyShifts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDailyActiveHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudActiveDaysInMonth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDailyHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSangShekaste)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudZaminTabiee)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaaseh)).BeginInit();
			this.SuspendLayout();
			// 
			// nudDailyShifts
			// 
			this.nudDailyShifts.Location = new System.Drawing.Point(399, 41);
			this.nudDailyShifts.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudDailyShifts.Name = "nudDailyShifts";
			this.nudDailyShifts.Size = new System.Drawing.Size(46, 21);
			this.nudDailyShifts.TabIndex = 5;
			this.nudDailyShifts.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// nudDailyActiveHours
			// 
			this.nudDailyActiveHours.DecimalPlaces = 1;
			this.nudDailyActiveHours.Location = new System.Drawing.Point(399, 78);
			this.nudDailyActiveHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.nudDailyActiveHours.Name = "nudDailyActiveHours";
			this.nudDailyActiveHours.Size = new System.Drawing.Size(46, 21);
			this.nudDailyActiveHours.TabIndex = 6;
			this.nudDailyActiveHours.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// lblDivider1
			// 
			this.lblDivider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDivider1.Location = new System.Drawing.Point(70, 124);
			this.lblDivider1.Name = "lblDivider1";
			this.lblDivider1.Size = new System.Drawing.Size(415, 2);
			this.lblDivider1.TabIndex = 13;
			// 
			// chkSiteMaaseh
			// 
			this.chkSiteMaaseh.AutoSize = true;
			this.chkSiteMaaseh.Location = new System.Drawing.Point(49, 246);
			this.chkSiteMaaseh.Name = "chkSiteMaaseh";
			this.chkSiteMaaseh.Size = new System.Drawing.Size(56, 17);
			this.chkSiteMaaseh.TabIndex = 12;
			this.chkSiteMaaseh.Text = "ماسه:";
			this.chkSiteMaaseh.UseVisualStyleBackColor = true;
			this.chkSiteMaaseh.CheckedChanged += new System.EventHandler(this.chkSiteMaaseh_CheckedChanged);
			// 
			// chkSiteRos
			// 
			this.chkSiteRos.AutoSize = true;
			this.chkSiteRos.Location = new System.Drawing.Point(49, 218);
			this.chkSiteRos.Name = "chkSiteRos";
			this.chkSiteRos.Size = new System.Drawing.Size(70, 17);
			this.chkSiteRos.TabIndex = 11;
			this.chkSiteRos.Text = "خاک رس:";
			this.chkSiteRos.UseVisualStyleBackColor = true;
			this.chkSiteRos.CheckedChanged += new System.EventHandler(this.chkSiteRos_CheckedChanged);
			// 
			// chkSiteZaminTabiee
			// 
			this.chkSiteZaminTabiee.AutoSize = true;
			this.chkSiteZaminTabiee.Location = new System.Drawing.Point(49, 190);
			this.chkSiteZaminTabiee.Name = "chkSiteZaminTabiee";
			this.chkSiteZaminTabiee.Size = new System.Drawing.Size(87, 17);
			this.chkSiteZaminTabiee.TabIndex = 10;
			this.chkSiteZaminTabiee.Text = "زمین طبیعی:";
			this.chkSiteZaminTabiee.UseVisualStyleBackColor = true;
			this.chkSiteZaminTabiee.CheckedChanged += new System.EventHandler(this.chkSiteZaminTabiee_CheckedChanged);
			// 
			// chkSiteSangShekaste
			// 
			this.chkSiteSangShekaste.AutoSize = true;
			this.chkSiteSangShekaste.Checked = true;
			this.chkSiteSangShekaste.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSiteSangShekaste.Location = new System.Drawing.Point(49, 162);
			this.chkSiteSangShekaste.Name = "chkSiteSangShekaste";
			this.chkSiteSangShekaste.Size = new System.Drawing.Size(98, 17);
			this.chkSiteSangShekaste.TabIndex = 9;
			this.chkSiteSangShekaste.Text = "سنگ شکسته:";
			this.chkSiteSangShekaste.UseVisualStyleBackColor = true;
			this.chkSiteSangShekaste.CheckedChanged += new System.EventHandler(this.chkSiteSangShekaste_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "ساعت کاری در هر شیفت";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "تعداد روز فعال در ماه";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label5.Location = new System.Drawing.Point(9, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "انواع خاک";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label6.ForeColor = System.Drawing.Color.Gray;
			this.label6.Location = new System.Drawing.Point(207, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 11);
			this.label6.TabIndex = 15;
			this.label6.Text = "حجم";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label10.Location = new System.Drawing.Point(9, 9);
			this.label10.Margin = new System.Windows.Forms.Padding(0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 13);
			this.label10.TabIndex = 14;
			this.label10.Text = "اطلاعات کلی";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(85, 17);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(400, 2);
			this.label11.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label7.ForeColor = System.Drawing.Color.Gray;
			this.label7.Location = new System.Drawing.Point(207, 196);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 11);
			this.label7.TabIndex = 15;
			this.label7.Text = "حجم";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label8.ForeColor = System.Drawing.Color.Gray;
			this.label8.Location = new System.Drawing.Point(207, 224);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 11);
			this.label8.TabIndex = 15;
			this.label8.Text = "حجم";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label9.ForeColor = System.Drawing.Color.Gray;
			this.label9.Location = new System.Drawing.Point(207, 252);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 11);
			this.label9.TabIndex = 15;
			this.label9.Text = "حجم";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(225, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "میزان ساعت مفید کار در هر شیفت";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(225, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "تعداد شیفت کاری در هر روز";
			// 
			// nudActiveDaysInMonth
			// 
			this.nudActiveDaysInMonth.Location = new System.Drawing.Point(161, 41);
			this.nudActiveDaysInMonth.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.nudActiveDaysInMonth.Name = "nudActiveDaysInMonth";
			this.nudActiveDaysInMonth.Size = new System.Drawing.Size(50, 21);
			this.nudActiveDaysInMonth.TabIndex = 7;
			this.nudActiveDaysInMonth.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// nudDailyHours
			// 
			this.nudDailyHours.DecimalPlaces = 1;
			this.nudDailyHours.Location = new System.Drawing.Point(161, 78);
			this.nudDailyHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.nudDailyHours.Name = "nudDailyHours";
			this.nudDailyHours.Size = new System.Drawing.Size(50, 21);
			this.nudDailyHours.TabIndex = 8;
			this.nudDailyHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// nudSangShekaste
			// 
			this.nudSangShekaste.Location = new System.Drawing.Point(236, 161);
			this.nudSangShekaste.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudSangShekaste.Name = "nudSangShekaste";
			this.nudSangShekaste.Size = new System.Drawing.Size(89, 21);
			this.nudSangShekaste.TabIndex = 8;
			this.nudSangShekaste.ThousandsSeparator = true;
			this.nudSangShekaste.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label12.ForeColor = System.Drawing.Color.Gray;
			this.label12.Location = new System.Drawing.Point(331, 168);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(43, 11);
			this.label12.TabIndex = 15;
			this.label12.Text = "متر مکعب";
			// 
			// nudZaminTabiee
			// 
			this.nudZaminTabiee.Enabled = false;
			this.nudZaminTabiee.Location = new System.Drawing.Point(236, 189);
			this.nudZaminTabiee.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudZaminTabiee.Name = "nudZaminTabiee";
			this.nudZaminTabiee.Size = new System.Drawing.Size(89, 21);
			this.nudZaminTabiee.TabIndex = 8;
			this.nudZaminTabiee.ThousandsSeparator = true;
			this.nudZaminTabiee.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			// 
			// nudRos
			// 
			this.nudRos.Enabled = false;
			this.nudRos.Location = new System.Drawing.Point(236, 217);
			this.nudRos.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudRos.Name = "nudRos";
			this.nudRos.Size = new System.Drawing.Size(89, 21);
			this.nudRos.TabIndex = 8;
			this.nudRos.ThousandsSeparator = true;
			this.nudRos.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			// 
			// nudMaaseh
			// 
			this.nudMaaseh.Enabled = false;
			this.nudMaaseh.Location = new System.Drawing.Point(236, 245);
			this.nudMaaseh.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudMaaseh.Name = "nudMaaseh";
			this.nudMaaseh.Size = new System.Drawing.Size(89, 21);
			this.nudMaaseh.TabIndex = 8;
			this.nudMaaseh.ThousandsSeparator = true;
			this.nudMaaseh.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label13.ForeColor = System.Drawing.Color.Gray;
			this.label13.Location = new System.Drawing.Point(331, 196);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(43, 11);
			this.label13.TabIndex = 15;
			this.label13.Text = "متر مکعب";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label14.ForeColor = System.Drawing.Color.Gray;
			this.label14.Location = new System.Drawing.Point(331, 224);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(43, 11);
			this.label14.TabIndex = 15;
			this.label14.Text = "متر مکعب";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label15.ForeColor = System.Drawing.Color.Gray;
			this.label15.Location = new System.Drawing.Point(331, 252);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(43, 11);
			this.label15.TabIndex = 15;
			this.label15.Text = "متر مکعب";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(410, 294);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 16;
			this.btnCancel.Text = "لغو";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(329, 294);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 17;
			this.btnOK.Text = "تأیید";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FormNewKhaakriziProject
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(490, 323);
			this.Controls.Add(this.nudDailyShifts);
			this.Controls.Add(this.nudDailyActiveHours);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblDivider1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.chkSiteMaaseh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nudMaaseh);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nudActiveDaysInMonth);
			this.Controls.Add(this.chkSiteRos);
			this.Controls.Add(this.nudDailyHours);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.chkSiteZaminTabiee);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.chkSiteSangShekaste);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.nudRos);
			this.Controls.Add(this.nudZaminTabiee);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nudSangShekaste);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "FormNewKhaakriziProject";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "پروژه خاک‎ریزی";
			this.Load += new System.EventHandler(this.FormNewKhaakriziProject_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudDailyShifts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDailyActiveHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudActiveDaysInMonth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDailyHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSangShekaste)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudZaminTabiee)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaaseh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudDailyShifts;
		private System.Windows.Forms.NumericUpDown nudDailyActiveHours;
		private System.Windows.Forms.NumericUpDown nudActiveDaysInMonth;
		private System.Windows.Forms.Label lblDivider1;
		private System.Windows.Forms.CheckBox chkSiteMaaseh;
		private System.Windows.Forms.CheckBox chkSiteRos;
		private System.Windows.Forms.CheckBox chkSiteZaminTabiee;
		private System.Windows.Forms.CheckBox chkSiteSangShekaste;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nudDailyHours;
		private System.Windows.Forms.NumericUpDown nudSangShekaste;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown nudZaminTabiee;
		private System.Windows.Forms.NumericUpDown nudRos;
		private System.Windows.Forms.NumericUpDown nudMaaseh;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}