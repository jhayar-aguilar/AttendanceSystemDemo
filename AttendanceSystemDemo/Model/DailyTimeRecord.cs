using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.Model
{
	class DailyTimeRecord
	{
		public int Id { get; set; }
		public Employee Employee { get; set; }
		public string EmployeeId { get; set; }
		public string DateLoggedIn { get; set; }
		public string Status { get; set; }
		public string TimeLoggedIn { get; set; }
		public string TimeLoggedOut { get; set; }
	}
}
