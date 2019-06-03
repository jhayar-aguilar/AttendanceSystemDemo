namespace AttendanceSystemDemo.View
{
	partial class Registration
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmpId = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.cbScheduleData = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter the required fields";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Employee ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "First Name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Last Name:";
			// 
			// txtEmpId
			// 
			this.txtEmpId.Location = new System.Drawing.Point(116, 33);
			this.txtEmpId.Name = "txtEmpId";
			this.txtEmpId.Size = new System.Drawing.Size(321, 20);
			this.txtEmpId.TabIndex = 1;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(116, 61);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(321, 20);
			this.txtFirstName.TabIndex = 2;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(116, 89);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(321, 20);
			this.txtLastName.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Password:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 177);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Confirm Password:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(116, 143);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(321, 20);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(116, 174);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(321, 20);
			this.txtConfirmPassword.TabIndex = 6;
			this.txtConfirmPassword.UseSystemPasswordChar = true;
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(12, 204);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(425, 23);
			this.btnRegister.TabIndex = 7;
			this.btnRegister.Text = "Add New Employee";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.Register);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(12, 233);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(425, 23);
			this.btnLogin.TabIndex = 8;
			this.btnLogin.Text = "Back to Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BackToLogin);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Schedule";
			// 
			// cbScheduleData
			// 
			this.cbScheduleData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbScheduleData.FormattingEnabled = true;
			this.cbScheduleData.Items.AddRange(new object[] {
            "Select a schedule"});
			this.cbScheduleData.Location = new System.Drawing.Point(116, 116);
			this.cbScheduleData.Name = "cbScheduleData";
			this.cbScheduleData.Size = new System.Drawing.Size(321, 21);
			this.cbScheduleData.TabIndex = 4;
			// 
			// Registration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 267);
			this.Controls.Add(this.cbScheduleData);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtEmpId);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Registration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registration";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmpId;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbScheduleData;
	}
}