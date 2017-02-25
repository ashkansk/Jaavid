namespace MachineCalculator.UI.Forms
{
	partial class ucKhaakriziProjectStep
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
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.rdbSangShekaste = new System.Windows.Forms.RadioButton();
			this.grpContainer = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.captionHelperBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.stepSoilObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtLoaderPerformanceValue = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblDivider1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbLoaderType = new System.Windows.Forms.ComboBox();
			this.machineBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nudWorkUnitQuantityStep1 = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblEnvFactor = new System.Windows.Forms.Label();
			this.cmbEnvFactor = new System.Windows.Forms.ComboBox();
			this.envFactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.rdbMaaseh = new System.Windows.Forms.RadioButton();
			this.rdbZaminTabiee = new System.Windows.Forms.RadioButton();
			this.rdbRos = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.grpContainer.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.captionHelperBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stepSoilObjBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWorkUnitQuantityStep1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.envFactorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.rdbSangShekaste, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.grpContainer, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.rdbMaaseh, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.rdbZaminTabiee, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.rdbRos, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 572);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// rdbSangShekaste
			// 
			this.rdbSangShekaste.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdbSangShekaste.Enabled = false;
			this.rdbSangShekaste.Location = new System.Drawing.Point(913, 3);
			this.rdbSangShekaste.Name = "rdbSangShekaste";
			this.rdbSangShekaste.Size = new System.Drawing.Size(85, 31);
			this.rdbSangShekaste.TabIndex = 2;
			this.rdbSangShekaste.Text = "سنگ شکسته";
			this.rdbSangShekaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdbSangShekaste.UseVisualStyleBackColor = true;
			this.rdbSangShekaste.CheckedChanged += new System.EventHandler(this.SoilTypeButton_Click);
			// 
			// grpContainer
			// 
			this.grpContainer.Controls.Add(this.tableLayoutPanel2);
			this.grpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpContainer.Location = new System.Drawing.Point(3, 3);
			this.grpContainer.Name = "grpContainer";
			this.tableLayoutPanel1.SetRowSpan(this.grpContainer, 4);
			this.grpContainer.Size = new System.Drawing.Size(904, 566);
			this.grpContainer.TabIndex = 1;
			this.grpContainer.TabStop = false;
			this.grpContainer.Text = "سنگ شکسته";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 6;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBox5, 4, 6);
			this.tableLayoutPanel2.Controls.Add(this.textBox3, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.textBox1, 4, 5);
			this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 6);
			this.tableLayoutPanel2.Controls.Add(this.label10, 3, 6);
			this.tableLayoutPanel2.Controls.Add(this.txtLoaderPerformanceValue, 4, 1);
			this.tableLayoutPanel2.Controls.Add(this.label6, 3, 5);
			this.tableLayoutPanel2.Controls.Add(this.lblDivider1, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.cmbLoaderType, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.nudWorkUnitQuantityStep1, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.label3, 3, 1);
			this.tableLayoutPanel2.Controls.Add(this.label5, 3, 2);
			this.tableLayoutPanel2.Controls.Add(this.numericUpDown3, 4, 2);
			this.tableLayoutPanel2.Controls.Add(this.label12, 2, 2);
			this.tableLayoutPanel2.Controls.Add(this.label11, 2, 5);
			this.tableLayoutPanel2.Controls.Add(this.lblEnvFactor, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.cmbEnvFactor, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.label4, 5, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 8;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(898, 546);
			this.tableLayoutPanel2.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.captionHelperBindingSource, "MachineTypeLabel", true));
			this.label1.Location = new System.Drawing.Point(828, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "نوع xxxxxxx";
			// 
			// captionHelperBindingSource
			// 
			this.captionHelperBindingSource.DataSource = typeof(MachineCalculator.UI.Helpers.CaptionHelper);
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stepSoilObjBindingSource, "RealRequiredMachineCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
			this.textBox5.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.textBox5.Location = new System.Drawing.Point(228, 185);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(162, 21);
			this.textBox5.TabIndex = 17;
			this.textBox5.Text = "0";
			// 
			// stepSoilObjBindingSource
			// 
			this.stepSoilObjBindingSource.DataSource = typeof(MachineCalculator.UI.Entities.ProjectStepSoil);
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stepSoilObjBindingSource, "WorkToDo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.textBox3.Location = new System.Drawing.Point(638, 147);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(162, 21);
			this.textBox3.TabIndex = 17;
			this.textBox3.Text = "0";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stepSoilObjBindingSource, "CurrentMachineRealPerformance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Location = new System.Drawing.Point(228, 147);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(162, 21);
			this.textBox1.TabIndex = 17;
			this.textBox1.Text = "0";
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stepSoilObjBindingSource, "RequiredMachineCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
			this.textBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox4.Location = new System.Drawing.Point(638, 185);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(162, 21);
			this.textBox4.TabIndex = 17;
			this.textBox4.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.captionHelperBindingSource, "MachineRoundedRequiredCountLabel", true));
			this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label10.Location = new System.Drawing.Point(407, 182);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(85, 39);
			this.label10.TabIndex = 0;
			this.label10.Text = "تعداد xxxxxxx مورد نیاز اصلاح شده";
			// 
			// txtLoaderPerformanceValue
			// 
			this.txtLoaderPerformanceValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stepSoilObjBindingSource, "CurrentMachinePerformance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
			this.txtLoaderPerformanceValue.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtLoaderPerformanceValue.Location = new System.Drawing.Point(228, 16);
			this.txtLoaderPerformanceValue.Name = "txtLoaderPerformanceValue";
			this.txtLoaderPerformanceValue.ReadOnly = true;
			this.txtLoaderPerformanceValue.Size = new System.Drawing.Size(162, 21);
			this.txtLoaderPerformanceValue.TabIndex = 17;
			this.txtLoaderPerformanceValue.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.captionHelperBindingSource, "MachineRealPerformanceLabel", true));
			this.label6.Location = new System.Drawing.Point(434, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 26);
			this.label6.TabIndex = 0;
			this.label6.Text = "توان واقعی xxxxxxx";
			// 
			// lblDivider1
			// 
			this.lblDivider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tableLayoutPanel2.SetColumnSpan(this.lblDivider1, 6);
			this.lblDivider1.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDivider1.Location = new System.Drawing.Point(10, 128);
			this.lblDivider1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.lblDivider1.Name = "lblDivider1";
			this.lblDivider1.Size = new System.Drawing.Size(878, 2);
			this.lblDivider1.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.captionHelperBindingSource, "MachineRequiredCountLabel", true));
			this.label8.Location = new System.Drawing.Point(820, 182);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 26);
			this.label8.TabIndex = 0;
			this.label8.Text = "تعداد xxxxxxx مورد نیاز";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.captionHelperBindingSource, "WorkQuantityLabel", true));
			this.label2.Location = new System.Drawing.Point(834, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "xxxxxxxxx";
			// 
			// cmbLoaderType
			// 
			this.cmbLoaderType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stepSoilObjBindingSource, "MachineID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cmbLoaderType.DataSource = this.machineBindingSource;
			this.cmbLoaderType.DisplayMember = "Title";
			this.cmbLoaderType.Dock = System.Windows.Forms.DockStyle.Top;
			this.cmbLoaderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLoaderType.FormattingEnabled = true;
			this.cmbLoaderType.Location = new System.Drawing.Point(638, 16);
			this.cmbLoaderType.Name = "cmbLoaderType";
			this.cmbLoaderType.Size = new System.Drawing.Size(162, 21);
			this.cmbLoaderType.TabIndex = 1;
			this.cmbLoaderType.Tag = "";
			this.cmbLoaderType.ValueMember = "ID";
			// 
			// machineBindingSource
			// 
			this.machineBindingSource.DataSource = typeof(MachineCalculator.UI.Entities.Machine);
			// 
			// nudWorkUnitQuantityStep1
			// 
			this.nudWorkUnitQuantityStep1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stepSoilObjBindingSource, "WorkQuantity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C0"));
			this.nudWorkUnitQuantityStep1.Dock = System.Windows.Forms.DockStyle.Top;
			this.nudWorkUnitQuantityStep1.Location = new System.Drawing.Point(638, 53);
			this.nudWorkUnitQuantityStep1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudWorkUnitQuantityStep1.Name = "nudWorkUnitQuantityStep1";
			this.nudWorkUnitQuantityStep1.Size = new System.Drawing.Size(162, 21);
			this.nudWorkUnitQuantityStep1.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label7.Location = new System.Drawing.Point(810, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 26);
			this.label7.TabIndex = 0;
			this.label7.Text = "حجم عملیاتی که باید انجام شود";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.captionHelperBindingSource, "MachinePerformanceLabel", true));
			this.label3.Location = new System.Drawing.Point(422, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "توان xxxxxxx";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(402, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 31);
			this.label5.TabIndex = 0;
			this.label5.Text = "ضریب اصلاح قضاوت مهندسی";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stepSoilObjBindingSource, "ExpertJudgementQuofficient", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
			this.numericUpDown3.DecimalPlaces = 2;
			this.numericUpDown3.Dock = System.Windows.Forms.DockStyle.Top;
			this.numericUpDown3.Location = new System.Drawing.Point(228, 53);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(162, 21);
			this.numericUpDown3.TabIndex = 2;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.captionHelperBindingSource, "WorkMetricUnit", true));
			this.label12.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label12.ForeColor = System.Drawing.Color.Gray;
			this.label12.Location = new System.Drawing.Point(611, 58);
			this.label12.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(21, 11);
			this.label12.TabIndex = 16;
			this.label12.Text = "xxxx";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label11.ForeColor = System.Drawing.Color.Gray;
			this.label11.Location = new System.Drawing.Point(555, 152);
			this.label11.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(77, 11);
			this.label11.TabIndex = 16;
			this.label11.Text = "متر مکعب / ساعت";
			// 
			// lblEnvFactor
			// 
			this.lblEnvFactor.AutoSize = true;
			this.lblEnvFactor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.captionHelperBindingSource, "EnvFactorLabel", true));
			this.lblEnvFactor.Location = new System.Drawing.Point(834, 83);
			this.lblEnvFactor.Name = "lblEnvFactor";
			this.lblEnvFactor.Size = new System.Drawing.Size(61, 13);
			this.lblEnvFactor.TabIndex = 0;
			this.lblEnvFactor.Text = "xxxxxxxxx";
			// 
			// cmbEnvFactor
			// 
			this.cmbEnvFactor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stepSoilObjBindingSource, "EnvironmentFactor", true));
			this.cmbEnvFactor.DataSource = this.envFactorBindingSource;
			this.cmbEnvFactor.DisplayMember = "Title";
			this.cmbEnvFactor.Dock = System.Windows.Forms.DockStyle.Top;
			this.cmbEnvFactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEnvFactor.FormattingEnabled = true;
			this.cmbEnvFactor.Location = new System.Drawing.Point(638, 86);
			this.cmbEnvFactor.Name = "cmbEnvFactor";
			this.cmbEnvFactor.Size = new System.Drawing.Size(162, 21);
			this.cmbEnvFactor.TabIndex = 19;
			this.cmbEnvFactor.Tag = "";
			this.cmbEnvFactor.ValueMember = "Value";
			// 
			// envFactorBindingSource
			// 
			this.envFactorBindingSource.DataSource = typeof(MachineCalculator.UI.Helpers.DoubleHelperClass);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label4.ForeColor = System.Drawing.Color.Gray;
			this.label4.Location = new System.Drawing.Point(145, 21);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 11);
			this.label4.TabIndex = 16;
			this.label4.Text = "متر مکعب / ساعت";
			// 
			// rdbMaaseh
			// 
			this.rdbMaaseh.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdbMaaseh.Enabled = false;
			this.rdbMaaseh.Location = new System.Drawing.Point(913, 114);
			this.rdbMaaseh.Name = "rdbMaaseh";
			this.rdbMaaseh.Size = new System.Drawing.Size(85, 31);
			this.rdbMaaseh.TabIndex = 2;
			this.rdbMaaseh.Text = "ماسه";
			this.rdbMaaseh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdbMaaseh.UseVisualStyleBackColor = true;
			this.rdbMaaseh.CheckedChanged += new System.EventHandler(this.SoilTypeButton_Click);
			// 
			// rdbZaminTabiee
			// 
			this.rdbZaminTabiee.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdbZaminTabiee.Enabled = false;
			this.rdbZaminTabiee.Location = new System.Drawing.Point(913, 40);
			this.rdbZaminTabiee.Name = "rdbZaminTabiee";
			this.rdbZaminTabiee.Size = new System.Drawing.Size(85, 31);
			this.rdbZaminTabiee.TabIndex = 2;
			this.rdbZaminTabiee.Text = "زمین طبیعی";
			this.rdbZaminTabiee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdbZaminTabiee.UseVisualStyleBackColor = true;
			this.rdbZaminTabiee.CheckedChanged += new System.EventHandler(this.SoilTypeButton_Click);
			// 
			// rdbRos
			// 
			this.rdbRos.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdbRos.Enabled = false;
			this.rdbRos.Location = new System.Drawing.Point(913, 77);
			this.rdbRos.Name = "rdbRos";
			this.rdbRos.Size = new System.Drawing.Size(85, 31);
			this.rdbRos.TabIndex = 2;
			this.rdbRos.Text = "خاک رس";
			this.rdbRos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdbRos.UseVisualStyleBackColor = true;
			this.rdbRos.CheckedChanged += new System.EventHandler(this.SoilTypeButton_Click);
			// 
			// ucKhaakriziProjectStep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "ucKhaakriziProjectStep";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(1001, 572);
			this.Load += new System.EventHandler(this.ucKhaakriziProjectStep_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.grpContainer.ResumeLayout(false);
			this.grpContainer.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.captionHelperBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stepSoilObjBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWorkUnitQuantityStep1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.envFactorBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.RadioButton rdbSangShekaste;
		private System.Windows.Forms.GroupBox grpContainer;
		private System.Windows.Forms.Label lblDivider1;
		private System.Windows.Forms.TextBox txtLoaderPerformanceValue;
		private System.Windows.Forms.BindingSource stepSoilObjBindingSource;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown nudWorkUnitQuantityStep1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdbMaaseh;
		private System.Windows.Forms.RadioButton rdbZaminTabiee;
		private System.Windows.Forms.RadioButton rdbRos;
		private System.Windows.Forms.ComboBox cmbLoaderType;
		private System.Windows.Forms.BindingSource machineBindingSource;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label lblEnvFactor;
		private System.Windows.Forms.ComboBox cmbEnvFactor;
		private System.Windows.Forms.BindingSource envFactorBindingSource;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.BindingSource captionHelperBindingSource;
	}
}
