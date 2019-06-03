using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.Model
{
	public class Schedule
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public string StartTime { get; set; }
		public string EndTime { get; set; }
	}
}
