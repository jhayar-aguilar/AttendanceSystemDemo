using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.View
{
	interface IRegistrationView
	{
		string EmployeeId { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		int ScheduleId { get; set; }
		string Password { get; set; }
	}
}
