namespace AttendanceSystemDemo.View
{
	partial class Dashboard
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.timeLogDataView = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lblRealTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.lblEmpName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataView)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hello, ";
			// 
			// timeLogDataView
			// 
			this.timeLogDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.timeLogDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.timeLogDataView.Location = new System.Drawing.Point(15, 105);
			this.timeLogDataView.Name = "timeLogDataView";
			this.timeLogDataView.ReadOnly = true;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
			this.timeLogDataView.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.timeLogDataView.Size = new System.Drawing.Size(456, 172);
			this.timeLogDataView.TabIndex = 4;
			this.timeLogDataView.SelectionChanged += new System.EventHandler(this.GridViewClearSelection);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(485, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.logoutToolStripMenuItem.Text = "Logout";
			this.logoutToolStripMenuItem.Click += new System.EventHandler(this.Logout);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.CloseApplication);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 283);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(225, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Time-in";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.TimeIn);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(246, 283);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(225, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Time-out";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.TimeOut);
			// 
			// lblRealTime
			// 
			this.lblRealTime.AutoSize = true;
			this.lblRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRealTime.Location = new System.Drawing.Point(271, 30);
			this.lblRealTime.Name = "lblRealTime";
			this.lblRealTime.Size = new System.Drawing.Size(200, 37);
			this.lblRealTime.TabIndex = 11;
			this.lblRealTime.Text = "00:00:00 AM";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(15, 76);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(456, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "View Employee Info";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.ShowEmployeeInfo);
			// 
			// lblEmpName
			// 
			this.lblEmpName.AutoSize = true;
			this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmpName.Location = new System.Drawing.Point(62, 48);
			this.lblEmpName.Name = "lblEmpName";
			this.lblEmpName.Size = new System.Drawing.Size(13, 13);
			this.lblEmpName.TabIndex = 5;
			this.lblEmpName.Text = "--";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 318);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.lblRealTime);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblEmpName);
			this.Controls.Add(this.timeLogDataView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataView)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView timeLogDataView;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lblRealTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label lblEmpName;
	}
}