using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.BusinessLayer
{
	interface ITimeLog
	{
		void TimeIn();
		void TimeOut();
	}
}
