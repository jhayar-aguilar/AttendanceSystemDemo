using AttendanceSystemDemo.BusinessLayer;
using AttendanceSystemDemo.Data;
using AttendanceSystemDemo.Model;
using AttendanceSystemDemo.Presenter;
using AttendanceSystemDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystemDemo.View
{
	public partial class Dashboard : Form, IDashboardView
	{
		private DashboardPresenter dashboardPresenter;

		private Employee _employee;
		private BindingList<DailyTimeRecordViewModel> timeLogs;

		private static int idCounter = 5;

		private DailyTimeRecord dtr;

		//private static bool hasTimeIn = false;

		public Employee EmployeeInfo
		{
			get => _employee;
			set => _employee = value;
		}

		public string FullName
		{
			get => lblEmpName.Text;
			set => lblEmpName.Text = value;
		}

		public Dashboard()
		{
			InitializeComponent();
		}

		//private void NewDashboardPresenter() => dashboardPresenter = new DashboardPresenter(this);

		public Dashboard(Employee employee)
		{
			InitializeComponent();

			_employee = employee;

			dashboardPresenter = new DashboardPresenter(this, new TimeLog());
		}

		private void Logout(object sender, EventArgs e)
		{
			dashboardPresenter.Logout();
		}

		private void CloseApplication(object sender, EventArgs e)
		{
			dashboardPresenter.CloseApplication();
		}

		private void TimeOut(object sender, EventArgs e)
		{
			//dashboardPresenter.TimeOut();

			if (_employee.HasTimeLoggedIn)
			{
				var timeLoggedOut = Convert.ToDateTime(lblRealTime.Text).ToString("hh:mm tt");

				dtr.TimeLoggedOut = timeLoggedOut;

				timeLogs.Last().TimeLoggedOut = timeLoggedOut;

				//var dtr = new DailyTimeRecord
				//{
				//	EmployeeId = _employee.EmployeeId,

				//	Employee = new EmployeeData().GetData()
				//		.SingleOrDefault(emp => emp.EmployeeId == _employee.EmployeeId),

				//	//TimeLoggedIn = _employee

				//	TimeLoggedOut = Convert.ToDateTime(lblRealTime.Text).ToString("hh:mm tt")
				//};



				//var startTime = Convert.ToDateTime(timeLogs.Last().TimeLoggedIn);
				//var employeeStartTime = Convert.ToDateTime(_employee.Schedule.StartTime);
				//var endTime = Convert.ToDateTime(lblRealTime.Text);
				//var employeeEndTime = Convert.ToDateTime(_employee.Schedule.EndTime);






				_employee.HasTimeLoggedIn = false;
				//dashboardPresenter.TimeOut(dtr, _employee);
				timeLogDataView.Refresh();

				UpdateColor();
			}
		}

		private void TimeIn(object sender, EventArgs e)
		{
			//var d = DateTime.Today.Add(new TimeSpan(8, 0, 0)).ToString("hh:mm:ss tt");
			
			if (!_employee.HasTimeLoggedIn)
			{
				dtr = new DailyTimeRecord
				{
					Id = idCounter,
					Employee = _employee,
					EmployeeId = _employee.EmployeeId,
					DateLoggedIn = DateTime.Today.ToShortDateString(),
					TimeLoggedIn = Convert.ToDateTime(lblRealTime.Text).ToString("hh:mm tt")
				};

				//timeLogs.Add(new DailyTimeRecordViewModel
				//{
				//	DateLoggedIn = DateTime.Today.ToShortDateString(),
				//	TimeLoggedIn = Convert.ToDateTime(lblRealTime.Text).ToString("hh:mm tt")
				//});

				timeLogs.Add(new DailyTimeRecordViewModel
				{
					DateLoggedIn = dtr.DateLoggedIn,
					TimeLoggedIn = dtr.TimeLoggedIn
				});

				_employee.HasTimeLoggedIn = true;

				dashboardPresenter.TimeIn(dtr);

				timeLogDataView.DataSource = timeLogs;

				idCounter++;

				////if (timeLogs.Count == 0)
				////else
				////	timeLogDataView.Refresh();

			}

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//dashboardPresenter.UpdateClock();

			lblRealTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
		}

		private void UpdateGridView(object sender, EventArgs e)
		{
			timeLogDataView.DataSource = timeLogs;
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			//lblEmpName.Text = _employee.LastName + ", " + _employee.FirstName;

			FullName = _employee.LastName + ", " + _employee.FirstName;

			var test = new DailyTimeRecordData()
				.GetData()
				.Where(d => d.EmployeeId == _employee.EmployeeId).ToList();

			var dtrViewModel = new List<DailyTimeRecordViewModel>();

			foreach (var item in test)
			{
				dtrViewModel.Add(new DailyTimeRecordViewModel
				{
					DateLoggedIn = item.DateLoggedIn,
					TimeLoggedIn = item.TimeLoggedIn,
					TimeLoggedOut = item.TimeLoggedOut
				});
			}

			timeLogs = new BindingList<DailyTimeRecordViewModel>(dtrViewModel);

			//timeLogDataView.DataSource = new List<DailyTimeRecordViewModel>();

			timeLogDataView.DataSource = timeLogs;
			//timeLogDataView.Sort(timeLogDataView.Columns[0], ListSortDirection.Ascending);

			UpdateColor();
		}

		private void GridViewClearSelection(object sender, EventArgs e)
		{
			timeLogDataView.ClearSelection();
		}

		private void ShowEmployeeInfo(object sender, EventArgs e)
		{
			new EmployeeInfo(_employee).Show();
		}

		private void DataGridView()
		{
			//timeLogDataView.DataSource = 
		}

		private void UpdateColor()
		{
			foreach (DataGridViewRow item in
				timeLogDataView.Rows.Cast<DataGridViewRow>().Take(timeLogDataView.Rows.Count - 1))
			{
				//var tIn = Convert.ToDateTime(item.Cells["TimeLoggedIn"].Value).TimeOfDay;
				//var tOut = Convert.ToDateTime(item.Cells["TimeLoggedOut"].Value).TimeOfDay;

				//var sTime = Convert.ToDateTime(_employee.Schedule.StartTime).TimeOfDay;
				//var eTime = Convert.ToDateTime(_employee.Schedule.EndTime).TimeOfDay;

				//if((tIn > sTime))
				//{

				//}

				if (item.Cells["TimeLoggedOut"].Value != null)
				{
					if ((Convert.ToDateTime(item.Cells["TimeLoggedIn"].Value).TimeOfDay > Convert.ToDateTime(_employee.Schedule.StartTime).TimeOfDay ||
						Convert.ToDateTime(item.Cells["TimeLoggedOut"].Value).TimeOfDay < Convert.ToDateTime(_employee.Schedule.EndTime).TimeOfDay))
					{
						item.DefaultCellStyle.BackColor = Color.DarkRed;
						item.DefaultCellStyle.ForeColor = Color.White;
					}

					else
					{
						item.DefaultCellStyle.BackColor = Color.ForestGreen;
						item.DefaultCellStyle.ForeColor = Color.White;
					}
				}

			}

			//for (int i = 0; i < timeLogDataView.Rows.Count - 1; i++)
			//{
			//	if (Convert.ToDateTime(timeLogDataView.Rows[i].Cells[1].Value) > Convert.ToDateTime(_employee.Schedule.StartTime) &&
			//		Convert.ToDateTime(timeLogDataView.Rows[i].Cells[2].Value) > Convert.ToDateTime(_employee.Schedule.EndTime))
			//	{
			//		timeLogDataView.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
			//		timeLogDataView.Rows[i].DefaultCellStyle.ForeColor = Color.White;
			//	}

			//	else
			//	{
			//		timeLogDataView.Rows[i].DefaultCellStyle.BackColor = Color.DarkGreen;
			//		timeLogDataView.Rows[i].DefaultCellStyle.ForeColor = Color.White;
			//	}
			//}
		}
	}
}
