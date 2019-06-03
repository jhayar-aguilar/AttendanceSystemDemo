namespace AttendanceSystemDemo.View
{
	partial class EmployeeInfo
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblScheduleType = new System.Windows.Forms.Label();
			this.lblStartTime = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblEndTime = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Employee Info:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Employee Name:";
			// 
			// lblEmployeeName
			// 
			this.lblEmployeeName.AutoSize = true;
			this.lblEmployeeName.Location = new System.Drawing.Point(105, 51);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new System.Drawing.Size(13, 13);
			this.lblEmployeeName.TabIndex = 2;
			this.lblEmployeeName.Text = "--";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Work Schedule:";
			// 
			// lblScheduleType
			// 
			this.lblScheduleType.AutoSize = true;
			this.lblScheduleType.Location = new System.Drawing.Point(105, 95);
			this.lblScheduleType.Name = "lblScheduleType";
			this.lblScheduleType.Size = new System.Drawing.Size(13, 13);
			this.lblScheduleType.TabIndex = 4;
			this.lblScheduleType.Text = "--";
			// 
			// lblStartTime
			// 
			this.lblStartTime.AutoSize = true;
			this.lblStartTime.Location = new System.Drawing.Point(105, 123);
			this.lblStartTime.Name = "lblStartTime";
			this.lblStartTime.Size = new System.Drawing.Size(13, 13);
			this.lblStartTime.TabIndex = 6;
			this.lblStartTime.Text = "--";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(38, 123);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Start Time:";
			// 
			// lblEndTime
			// 
			this.lblEndTime.AutoSize = true;
			this.lblEndTime.Location = new System.Drawing.Point(105, 151);
			this.lblEndTime.Name = "lblEndTime";
			this.lblEndTime.Size = new System.Drawing.Size(13, 13);
			this.lblEndTime.TabIndex = 8;
			this.lblEndTime.Text = "--";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(41, 151);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "End Time:";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(15, 177);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(291, 23);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.CloseDialog);
			// 
			// EmployeeInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 216);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblEndTime);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblStartTime);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblScheduleType);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblEmployeeName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "EmployeeInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EmployeeInfo";
			this.Load += new System.EventHandler(this.EmployeeInfo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblEmployeeName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblScheduleType;
		private System.Windows.Forms.Label lblStartTime;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblEndTime;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnClose;
	}
}