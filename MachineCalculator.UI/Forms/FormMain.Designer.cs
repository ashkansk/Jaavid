namespace MachineCalculator.UI.Forms
{
	partial class FormMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mItemProject = new System.Windows.Forms.ToolStripMenuItem();
			this.mItemNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mItemKhaakriziProject = new System.Windows.Forms.ToolStripMenuItem();
			this.حفاریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.mItemSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mItemClearForm = new System.Windows.Forms.ToolStripMenuItem();
			this.lblUserGuide = new System.Windows.Forms.Label();
			this.grpContainer = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip1.SuspendLayout();
			this.grpContainer.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemProject,
            this.mItemClearForm});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(864, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mItemProject
			// 
			this.mItemProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemNew,
            this.mItemSave});
			this.mItemProject.Name = "mItemProject";
			this.mItemProject.Size = new System.Drawing.Size(43, 20);
			this.mItemProject.Text = "پروژه";
			// 
			// mItemNew
			// 
			this.mItemNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemKhaakriziProject,
            this.حفاریToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
			this.mItemNew.Name = "mItemNew";
			this.mItemNew.Size = new System.Drawing.Size(101, 22);
			this.mItemNew.Text = "جدید";
			// 
			// mItemKhaakriziProject
			// 
			this.mItemKhaakriziProject.Name = "mItemKhaakriziProject";
			this.mItemKhaakriziProject.Size = new System.Drawing.Size(122, 22);
			this.mItemKhaakriziProject.Text = "خاکریزی...";
			this.mItemKhaakriziProject.Click += new System.EventHandler(this.mItemKhaakriziProject_Click);
			// 
			// حفاریToolStripMenuItem
			// 
			this.حفاریToolStripMenuItem.Enabled = false;
			this.حفاریToolStripMenuItem.Name = "حفاریToolStripMenuItem";
			this.حفاریToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.حفاریToolStripMenuItem.Text = "حفاری...";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Enabled = false;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
			this.toolStripMenuItem2.Text = "...";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Enabled = false;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 22);
			this.toolStripMenuItem3.Text = "...";
			// 
			// mItemSave
			// 
			this.mItemSave.Name = "mItemSave";
			this.mItemSave.Size = new System.Drawing.Size(101, 22);
			this.mItemSave.Text = "ذخیره";
			// 
			// mItemClearForm
			// 
			this.mItemClearForm.Name = "mItemClearForm";
			this.mItemClearForm.Size = new System.Drawing.Size(64, 20);
			this.mItemClearForm.Text = "پاک کردن";
			// 
			// lblUserGuide
			// 
			this.lblUserGuide.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.lblUserGuide.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblUserGuide.Location = new System.Drawing.Point(20, 24);
			this.lblUserGuide.Name = "lblUserGuide";
			this.lblUserGuide.Size = new System.Drawing.Size(829, 87);
			this.lblUserGuide.TabIndex = 2;
			this.lblUserGuide.Text = "برای ایجاد یک پروژه جدید، از منوی بالا گزینه پروژه --> جدید را باز کرده و یکی از " +
    "4 نوع پروژه موجود را انتخاب کنید تا فرم مربوط به آن نمایش داده شود.";
			// 
			// grpContainer
			// 
			this.grpContainer.Controls.Add(this.lblUserGuide);
			this.grpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpContainer.Location = new System.Drawing.Point(3, 16);
			this.grpContainer.Name = "grpContainer";
			this.grpContainer.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.grpContainer.Size = new System.Drawing.Size(858, 385);
			this.grpContainer.TabIndex = 3;
			this.grpContainer.TabStop = false;
			this.grpContainer.Text = "راهنما";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.grpContainer, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(864, 404);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 428);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "محاسبه گر";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.grpContainer.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mItemProject;
		private System.Windows.Forms.ToolStripMenuItem mItemClearForm;
		private System.Windows.Forms.ToolStripMenuItem mItemNew;
		private System.Windows.Forms.ToolStripMenuItem mItemSave;
		private System.Windows.Forms.ToolStripMenuItem mItemKhaakriziProject;
		private System.Windows.Forms.ToolStripMenuItem حفاریToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.Label lblUserGuide;
		private System.Windows.Forms.GroupBox grpContainer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}