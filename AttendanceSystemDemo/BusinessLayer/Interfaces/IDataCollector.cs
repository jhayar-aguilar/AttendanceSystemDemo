using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.BusinessLayer
{
	interface IDataCollector<T>
	{
		T GetData();
		T GetItem();
	}
}
