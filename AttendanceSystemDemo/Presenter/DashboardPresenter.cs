using AttendanceSystemDemo.BusinessLayer;
using AttendanceSystemDemo.Data;
using AttendanceSystemDemo.Model;
using AttendanceSystemDemo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystemDemo.Presenter
{
	class DashboardPresenter
	{
		private readonly IDashboardView _dashboardView;
		private readonly ITimeLog _timeLogger;

		public DashboardPresenter(
			IDashboardView dashboardView,
			ITimeLog timeLogger)
		{
			_dashboardView = dashboardView;
			_timeLogger = timeLogger;
		}

		public void Logout()
		{
			if (_dashboardView is Dashboard form)
			{
				form.Close();
				//Environment.Exit(0);
				Thread th = new Thread(() => Application.Run(new Main()));
				th.Start();
			}
		}

		public void CloseApplication() => Application.Exit();

		public void TimeOut(DailyTimeRecord dtr, Employee emp)
		{
			//new DailyTimeRecordData().UpdateData(dtr);

			//new EmployeeData().UpdateData(emp);




			//if (hasTimeIn)
			//{
			//	var startTime = Convert.ToDateTime(timeLogs.Last().StartTime);
			//	var employeeStartTime = Convert.ToDateTime(_employee.Schedule.StartTime);
			//	var endTime = Convert.ToDateTime(lblRealTime.Text);
			//	var employeeEndTime = Convert.ToDateTime(_employee.Schedule.EndTime);
			//	timeLogs.Last().EndTime = endTime.ToString("hh:mm tt");

			//	if (startTime <= employeeStartTime && endTime >= employeeEndTime)
			//	{
			//		//timeLogs.Last().Status = "On Time";
			//		timeLogDataView.Rows[timeLogDataView.Rows.Count - 2].DefaultCellStyle.BackColor = Color.DarkGreen;
			//		timeLogDataView.Rows[timeLogDataView.Rows.Count - 2].DefaultCellStyle.ForeColor = Color.White;
			//	}
			//	else
			//	{
			//		//timeLogs.Last().Status = "Late";
			//		timeLogDataView.Rows[timeLogDataView.Rows.Count - 2].DefaultCellStyle.BackColor = Color.DarkRed;
			//		timeLogDataView.Rows[timeLogDataView.Rows.Count - 2].DefaultCellStyle.ForeColor = Color.White;
			//	}

			//	hasTimeIn = false;
			//	timeLogDataView.Refresh();
			//}
		}

		public void TimeIn(DailyTimeRecord dtr)
		{
			new DailyTimeRecordData().AddData(dtr);




			//if (!hasTimeIn)
			//{
			//	timeLogs.Add(new DailyTimeRecordViewModel
			//	{
			//		//Id = null,
			//		DateLoggedIn = DateTime.Today.ToShortDateString(),
			//		StartTime = Convert.ToDateTime(lblRealTime.Text).ToString("hh:mm tt")
			//	});

			//	timeLogDataView.DataSource = timeLogs;

			//	hasTimeIn = true;
			//}
		}

		//public void UpdateClock() =>
		//	_form..Text = DateTime.Now.ToString("hh:mm:ss tt");

	}
}
