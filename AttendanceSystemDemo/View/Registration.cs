using AttendanceSystemDemo.Data;
using AttendanceSystemDemo.Model;
using AttendanceSystemDemo.Presenter;
using AttendanceSystemDemo.ViewModel;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace AttendanceSystemDemo.View
{
	public partial class Registration : Form, IRegistrationView
	{
		private RegistrationPresenter registrationPresenter;
		private ScheduleData scheduleData = new ScheduleData();

		public string EmployeeId
		{
			get => txtEmpId.Text;
			set => txtEmpId.Text = value;
		}

		public string FirstName
		{
			get => txtFirstName.Text;
			set => txtFirstName.Text = value;
		}

		public string LastName
		{
			get => txtLastName.Text;
			set => txtLastName.Text = value;
		}

		public int ScheduleId
		{
			get => cbScheduleData.SelectedIndex;
			set => cbScheduleData.SelectedIndex = value;
		}

		public string Password
		{
			get => txtPassword.Text;
			set => txtPassword.Text = value;
		}

		public Registration()
		{
			InitializeComponent();

			cbScheduleData.SelectedIndex = 0;

			foreach (Schedule schedule in scheduleData.GetData())
			{
				cbScheduleData.Items.Add(schedule.StartTime + " - " + schedule.EndTime);
			}

			registrationPresenter = new RegistrationPresenter(this);
		}

		private void Register(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtEmpId.Text))
			{
				MessageBox.Show("Employee ID is required");
				return;
			}

			if (new EmployeeData().IsIdAlreadyExists(txtEmpId.Text))
			{
				MessageBox.Show("ID already exists");
				return;
			}

			if (string.IsNullOrEmpty(txtFirstName.Text))
			{
				MessageBox.Show("First name is required");
				return;
			}

			if(string.IsNullOrEmpty(txtLastName.Text))
			{
				MessageBox.Show("Last name is required");
				return;
			}

			if (cbScheduleData.SelectedIndex == 0)
			{
				MessageBox.Show("Select your schedule");
				return;
			}

			if(string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show("Password is required");
				return;
			}

			if(string.IsNullOrEmpty(txtConfirmPassword.Text))
			{
				MessageBox.Show("Please re-type your password");
				return;
			}

			if(txtPassword.Text != txtConfirmPassword.Text)
			{
				MessageBox.Show("Incorrect re-typed password");
				return;
			}

			var newEmployee = new Employee
			{
				//EmployeeId = txtEmpId.Text,
				//FirstName = txtFirstName.Text,
				//LastName = txtLastName.Text,
				//ScheduleId = cbScheduleData.SelectedIndex,
				//Schedule = new ScheduleData().GetData().SingleOrDefault(s => s.Id == 3),
				//Password = txtPassword.Text

				EmployeeId = EmployeeId,
				FirstName = FirstName,
				LastName = LastName,
				ScheduleId = ScheduleId,
				HasTimeLoggedIn = false,
				Schedule = new ScheduleData().GetData().SingleOrDefault(s => s.Id == ScheduleId),
				Password = Password
			};

			registrationPresenter.Register(newEmployee);
		}

		private void BackToLogin(object sender, EventArgs e)
		{
			this.Close();
			Thread th = new Thread(() => Application.Run(new Main()));
			th.Start();
		}
	}
}