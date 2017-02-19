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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mItemProject = new System.Windows.Forms.ToolStripMenuItem();
			this.mItemClearForm = new System.Windows.Forms.ToolStripMenuItem();
			this.mItemNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mItemSave = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(74, 108);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(662, 144);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemProject,
            this.mItemClearForm});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(918, 24);
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
			// mItemClearForm
			// 
			this.mItemClearForm.Name = "mItemClearForm";
			this.mItemClearForm.Size = new System.Drawing.Size(64, 20);
			this.mItemClearForm.Text = "پاک کردن";
			// 
			// mItemNew
			// 
			this.mItemNew.Name = "mItemNew";
			this.mItemNew.Size = new System.Drawing.Size(152, 22);
			this.mItemNew.Text = "جدید";
			this.mItemNew.Click += new System.EventHandler(this.mItemNew_Click);
			// 
			// mItemSave
			// 
			this.mItemSave.Name = "mItemSave";
			this.mItemSave.Size = new System.Drawing.Size(152, 22);
			this.mItemSave.Text = "ذخیره";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 592);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.Text = "FormMain";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mItemProject;
		private System.Windows.Forms.ToolStripMenuItem mItemClearForm;
		private System.Windows.Forms.ToolStripMenuItem mItemNew;
		private System.Windows.Forms.ToolStripMenuItem mItemSave;
	}
}