using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.Model
{
	public class Employee
	{
		public int Id { get; set; }
		public string EmployeeId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Password { get; set; }
		public Schedule Schedule { get; set; }
		public int ScheduleId { get; set; }
		public bool HasTimeLoggedIn { get; set; }
										   //public string ScheduleType { get; set; }
	}
}
