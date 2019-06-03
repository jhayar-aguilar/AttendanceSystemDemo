using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.View
{
	interface ILoginView
	{
		string EmployeeId { get; set; }
		string Password { get; set; }
	}
}
