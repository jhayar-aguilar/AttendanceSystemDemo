using AttendanceSystemDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.View
{
	interface IDashboardView
	{
		Employee EmployeeInfo { get; set; }
		string FullName { get; set; }
	}
}
