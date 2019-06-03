using AttendanceSystemDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.ViewModel
{
	class DailyTimeRecordViewModel
	{
		public string DateLoggedIn { get; set; }
		public string TimeLoggedIn { get; set; }
		public string TimeLoggedOut { get; set; }
		public string Status { get; set; }
	}
}
