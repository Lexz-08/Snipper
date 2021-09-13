
namespace Snipper
{
	partial class Form1
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
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.pnlMinimize = new System.Windows.Forms.Panel();
			this.lblMinimize = new System.Windows.Forms.Label();
			this.pnlMaximize = new System.Windows.Forms.Panel();
			this.lblMaximize = new System.Windows.Forms.Label();
			this.pnlClose = new System.Windows.Forms.Panel();
			this.lblClose = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.picTitleBarUnderline = new System.Windows.Forms.PictureBox();
			this.mnFileManager = new System.Windows.Forms.MenuStrip();
			this.btnSaveToFile = new System.Windows.Forms.ToolStripMenuItem();
			this.btnTakeSnapshot = new System.Windows.Forms.ToolStripMenuItem();
			this.picSnapshot = new System.Windows.Forms.PictureBox();
			this.lblXLocation = new System.Windows.Forms.Label();
			this.numXLocation = new System.Windows.Forms.NumericUpDown();
			this.numYLocation = new System.Windows.Forms.NumericUpDown();
			this.lblYLocation = new System.Windows.Forms.Label();
			this.numWidth = new System.Windows.Forms.NumericUpDown();
			this.lblWidth = new System.Windows.Forms.Label();
			this.numHeight = new System.Windows.Forms.NumericUpDown();
			this.lblHeight = new System.Windows.Forms.Label();
			this.pnlTitleBar.SuspendLayout();
			this.pnlMinimize.SuspendLayout();
			this.pnlMaximize.SuspendLayout();
			this.pnlClose.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picTitleBarUnderline)).BeginInit();
			this.mnFileManager.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picSnapshot)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numXLocation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numYLocation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.Controls.Add(this.pnlMinimize);
			this.pnlTitleBar.Controls.Add(this.pnlMaximize);
			this.pnlTitleBar.Controls.Add(this.pnlClose);
			this.pnlTitleBar.Controls.Add(this.lblTitle);
			this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
			this.pnlTitleBar.Name = "pnlTitleBar";
			this.pnlTitleBar.Size = new System.Drawing.Size(786, 32);
			this.pnlTitleBar.TabIndex = 0;
			// 
			// pnlMinimize
			// 
			this.pnlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMinimize.BackColor = System.Drawing.SystemColors.Control;
			this.pnlMinimize.Controls.Add(this.lblMinimize);
			this.pnlMinimize.Location = new System.Drawing.Point(690, 0);
			this.pnlMinimize.Name = "pnlMinimize";
			this.pnlMinimize.Size = new System.Drawing.Size(32, 32);
			this.pnlMinimize.TabIndex = 3;
			this.pnlMinimize.MouseEnter += new System.EventHandler(this.Minimize_MSEnter);
			this.pnlMinimize.MouseLeave += new System.EventHandler(this.Minimize_MSLeave);
			// 
			// lblMinimize
			// 
			this.lblMinimize.AutoSize = true;
			this.lblMinimize.Font = new System.Drawing.Font("Webdings", 10F);
			this.lblMinimize.Location = new System.Drawing.Point(5, 5);
			this.lblMinimize.Name = "lblMinimize";
			this.lblMinimize.Size = new System.Drawing.Size(23, 20);
			this.lblMinimize.TabIndex = 1;
			this.lblMinimize.Text = "0";
			this.lblMinimize.MouseEnter += new System.EventHandler(this.Minimize_MSEnter);
			this.lblMinimize.MouseLeave += new System.EventHandler(this.Minimize_MSLeave);
			// 
			// pnlMaximize
			// 
			this.pnlMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMaximize.BackColor = System.Drawing.SystemColors.Control;
			this.pnlMaximize.Controls.Add(this.lblMaximize);
			this.pnlMaximize.Location = new System.Drawing.Point(722, 0);
			this.pnlMaximize.Name = "pnlMaximize";
			this.pnlMaximize.Size = new System.Drawing.Size(32, 32);
			this.pnlMaximize.TabIndex = 2;
			this.pnlMaximize.MouseEnter += new System.EventHandler(this.Maximize_MSEnter);
			this.pnlMaximize.MouseLeave += new System.EventHandler(this.Maximize_MSLeave);
			// 
			// lblMaximize
			// 
			this.lblMaximize.AutoSize = true;
			this.lblMaximize.Font = new System.Drawing.Font("Webdings", 10F);
			this.lblMaximize.Location = new System.Drawing.Point(5, 6);
			this.lblMaximize.Name = "lblMaximize";
			this.lblMaximize.Size = new System.Drawing.Size(23, 20);
			this.lblMaximize.TabIndex = 1;
			this.lblMaximize.Text = "1";
			this.lblMaximize.MouseEnter += new System.EventHandler(this.Maximize_MSEnter);
			this.lblMaximize.MouseLeave += new System.EventHandler(this.Maximize_MSLeave);
			// 
			// pnlClose
			// 
			this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlClose.BackColor = System.Drawing.SystemColors.Control;
			this.pnlClose.Controls.Add(this.lblClose);
			this.pnlClose.Location = new System.Drawing.Point(754, 0);
			this.pnlClose.Name = "pnlClose";
			this.pnlClose.Size = new System.Drawing.Size(32, 32);
			this.pnlClose.TabIndex = 1;
			this.pnlClose.MouseEnter += new System.EventHandler(this.Close_MSEnter);
			this.pnlClose.MouseLeave += new System.EventHandler(this.Close_MSLeave);
			// 
			// lblClose
			// 
			this.lblClose.AutoSize = true;
			this.lblClose.Font = new System.Drawing.Font("Webdings", 10F);
			this.lblClose.Location = new System.Drawing.Point(5, 6);
			this.lblClose.Name = "lblClose";
			this.lblClose.Size = new System.Drawing.Size(23, 20);
			this.lblClose.TabIndex = 0;
			this.lblClose.Text = "r";
			this.lblClose.MouseEnter += new System.EventHandler(this.Close_MSEnter);
			this.lblClose.MouseLeave += new System.EventHandler(this.Close_MSLeave);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(6, 7);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(55, 19);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Snipper";
			// 
			// picTitleBarUnderline
			// 
			this.picTitleBarUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picTitleBarUnderline.BackColor = System.Drawing.Color.Gainsboro;
			this.picTitleBarUnderline.Location = new System.Drawing.Point(0, 32);
			this.picTitleBarUnderline.Name = "picTitleBarUnderline";
			this.picTitleBarUnderline.Size = new System.Drawing.Size(786, 1);
			this.picTitleBarUnderline.TabIndex = 1;
			this.picTitleBarUnderline.TabStop = false;
			// 
			// mnFileManager
			// 
			this.mnFileManager.AutoSize = false;
			this.mnFileManager.BackColor = System.Drawing.SystemColors.Window;
			this.mnFileManager.Dock = System.Windows.Forms.DockStyle.None;
			this.mnFileManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveToFile,
            this.btnTakeSnapshot});
			this.mnFileManager.Location = new System.Drawing.Point(0, 37);
			this.mnFileManager.Name = "mnFileManager";
			this.mnFileManager.ShowItemToolTips = true;
			this.mnFileManager.Size = new System.Drawing.Size(649, 24);
			this.mnFileManager.TabIndex = 2;
			this.mnFileManager.Text = "menuStrip1";
			// 
			// btnSaveToFile
			// 
			this.btnSaveToFile.Name = "btnSaveToFile";
			this.btnSaveToFile.Size = new System.Drawing.Size(79, 20);
			this.btnSaveToFile.Text = "Save To File";
			this.btnSaveToFile.ToolTipText = "Save the current snapshot to an image file";
			this.btnSaveToFile.Click += new System.EventHandler(this.SaveSnapshot);
			// 
			// btnTakeSnapshot
			// 
			this.btnTakeSnapshot.Name = "btnTakeSnapshot";
			this.btnTakeSnapshot.Size = new System.Drawing.Size(94, 20);
			this.btnTakeSnapshot.Text = "Take Snapshot";
			this.btnTakeSnapshot.ToolTipText = "Create a new snapshot, or overwrite the current one";
			this.btnTakeSnapshot.Click += new System.EventHandler(this.TakeSnapshot);
			// 
			// picSnapshot
			// 
			this.picSnapshot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picSnapshot.BackColor = System.Drawing.SystemColors.Control;
			this.picSnapshot.Location = new System.Drawing.Point(12, 64);
			this.picSnapshot.Name = "picSnapshot";
			this.picSnapshot.Size = new System.Drawing.Size(640, 378);
			this.picSnapshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picSnapshot.TabIndex = 3;
			this.picSnapshot.TabStop = false;
			// 
			// lblXLocation
			// 
			this.lblXLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblXLocation.AutoSize = true;
			this.lblXLocation.Location = new System.Drawing.Point(658, 64);
			this.lblXLocation.Name = "lblXLocation";
			this.lblXLocation.Size = new System.Drawing.Size(20, 19);
			this.lblXLocation.TabIndex = 4;
			this.lblXLocation.Text = "X:";
			// 
			// numXLocation
			// 
			this.numXLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numXLocation.Location = new System.Drawing.Point(684, 62);
			this.numXLocation.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numXLocation.Name = "numXLocation";
			this.numXLocation.Size = new System.Drawing.Size(90, 25);
			this.numXLocation.TabIndex = 5;
			this.numXLocation.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numYLocation
			// 
			this.numYLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numYLocation.Location = new System.Drawing.Point(684, 93);
			this.numYLocation.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numYLocation.Name = "numYLocation";
			this.numYLocation.Size = new System.Drawing.Size(90, 25);
			this.numYLocation.TabIndex = 7;
			this.numYLocation.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// lblYLocation
			// 
			this.lblYLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblYLocation.AutoSize = true;
			this.lblYLocation.Location = new System.Drawing.Point(658, 95);
			this.lblYLocation.Name = "lblYLocation";
			this.lblYLocation.Size = new System.Drawing.Size(20, 19);
			this.lblYLocation.TabIndex = 6;
			this.lblYLocation.Text = "Y:";
			// 
			// numWidth
			// 
			this.numWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numWidth.Location = new System.Drawing.Point(684, 124);
			this.numWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numWidth.Name = "numWidth";
			this.numWidth.Size = new System.Drawing.Size(90, 25);
			this.numWidth.TabIndex = 9;
			this.numWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// lblWidth
			// 
			this.lblWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(658, 126);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(25, 19);
			this.lblWidth.TabIndex = 8;
			this.lblWidth.Text = "W:";
			// 
			// numHeight
			// 
			this.numHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numHeight.Location = new System.Drawing.Point(684, 155);
			this.numHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numHeight.Name = "numHeight";
			this.numHeight.Size = new System.Drawing.Size(90, 25);
			this.numHeight.TabIndex = 11;
			this.numHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// lblHeight
			// 
			this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblHeight.AutoSize = true;
			this.lblHeight.Location = new System.Drawing.Point(658, 157);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(22, 19);
			this.lblHeight.TabIndex = 10;
			this.lblHeight.Text = "H:";
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(786, 454);
			this.Controls.Add(this.numHeight);
			this.Controls.Add(this.lblHeight);
			this.Controls.Add(this.numWidth);
			this.Controls.Add(this.lblWidth);
			this.Controls.Add(this.numYLocation);
			this.Controls.Add(this.lblYLocation);
			this.Controls.Add(this.numXLocation);
			this.Controls.Add(this.lblXLocation);
			this.Controls.Add(this.picSnapshot);
			this.Controls.Add(this.picTitleBarUnderline);
			this.Controls.Add(this.pnlTitleBar);
			this.Controls.Add(this.mnFileManager);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.mnFileManager;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Snipper";
			this.pnlTitleBar.ResumeLayout(false);
			this.pnlTitleBar.PerformLayout();
			this.pnlMinimize.ResumeLayout(false);
			this.pnlMinimize.PerformLayout();
			this.pnlMaximize.ResumeLayout(false);
			this.pnlMaximize.PerformLayout();
			this.pnlClose.ResumeLayout(false);
			this.pnlClose.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picTitleBarUnderline)).EndInit();
			this.mnFileManager.ResumeLayout(false);
			this.mnFileManager.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picSnapshot)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numXLocation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numYLocation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlTitleBar;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox picTitleBarUnderline;
		private System.Windows.Forms.Panel pnlClose;
		private System.Windows.Forms.Panel pnlMinimize;
		private System.Windows.Forms.Panel pnlMaximize;
		private System.Windows.Forms.Label lblClose;
		private System.Windows.Forms.Label lblMinimize;
		private System.Windows.Forms.Label lblMaximize;
		private System.Windows.Forms.MenuStrip mnFileManager;
		private System.Windows.Forms.ToolStripMenuItem btnSaveToFile;
		private System.Windows.Forms.ToolStripMenuItem btnTakeSnapshot;
		private System.Windows.Forms.PictureBox picSnapshot;
		private System.Windows.Forms.Label lblXLocation;
		private System.Windows.Forms.NumericUpDown numXLocation;
		private System.Windows.Forms.NumericUpDown numYLocation;
		private System.Windows.Forms.Label lblYLocation;
		private System.Windows.Forms.NumericUpDown numWidth;
		private System.Windows.Forms.Label lblWidth;
		private System.Windows.Forms.NumericUpDown numHeight;
		private System.Windows.Forms.Label lblHeight;
	}
}

