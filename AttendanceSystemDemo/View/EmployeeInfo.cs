using AttendanceSystemDemo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystemDemo.View
{
	public partial class EmployeeInfo : Form, IEmployeeInfoView
	{
		private Employee _employee;

		public string EmployeeName
		{
			get => lblEmployeeName.Text;
			set => lblEmployeeName.Text = value;
		}

		public string ScheduleType
		{
			get => lblScheduleType.Text;
			set => lblScheduleType.Text = value;
		}

		public string StartTime
		{
			get => lblStartTime.Text;
			set => lblStartTime.Text = value;
		}

		public string EndTime
		{
			get => lblEndTime.Text;
			set => lblEndTime.Text = value;
		}

		public EmployeeInfo()
		{
			
		}

		public EmployeeInfo(Employee employee)
		{
			InitializeComponent();
			_employee = employee;
		}

		private void EmployeeInfo_Load(object sender, EventArgs e)
		{
			EmployeeName = _employee.LastName + ", " + _employee.FirstName;
			ScheduleType = _employee.Schedule.Type;
			StartTime = _employee.Schedule.StartTime;
			EndTime = _employee.Schedule.EndTime;

			//lblEmployeeName.Text = _employee.LastName + ", " + _employee.FirstName;
			//lblScheduleType.Text = _employee.ScheduleType;
			//lblStartTime.Text = _employee.Schedule.StartTime;
			//lblEndTime.Text = _employee.Schedule.EndTime;
		}

		private void CloseDialog(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
