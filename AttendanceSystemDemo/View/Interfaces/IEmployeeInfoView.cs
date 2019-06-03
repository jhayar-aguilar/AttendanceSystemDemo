using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.View
{
	interface IEmployeeInfoView
	{
		string EmployeeName { get; set; }
		string ScheduleType { get; set; }
		string StartTime { get; set; }
		string EndTime { get; set; }
	}
}
