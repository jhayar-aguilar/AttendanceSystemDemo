using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.Data
{
	interface IData<T>
	{
		List<T> GetData();
		T GetItem(string id);
		void AddData(T tData);
		bool IsIdAlreadyExists(string id);
		void UpdateData(string id);
	}
}
