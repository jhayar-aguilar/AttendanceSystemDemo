using AttendanceSystemDemo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceSystemDemo.ViewModel;
using AttendanceSystemDemo.Data;
using AttendanceSystemDemo.Model;

namespace AttendanceSystemDemo.BusinessLayer
{
	class Logger : ILogger
	{
		private EmployeeData empData = new EmployeeData();

		//public bool IsExisting()
		//{
		//	throw new NotImplementedException();
		//}

		public bool IsValidCredentials(EmployeeLoginViewModel empLoginViewModel)
		{
			return empData.GetData()
				.Any(e => e.EmployeeId == empLoginViewModel.EmployeeId &&
						  e.Password == empLoginViewModel.Password);

			//return true;
		}

		public Employee GetInformation<T>(string empId)
		{
			return empData.GetItem(empId);
		}

		public void Login()
		{
			throw new NotImplementedException();
		}

		public void Register()
		{
			throw new NotImplementedException();
		}

		public bool IsValidCredentials()
		{
			return true;
		}

		//private Dictionary<string, Employee> GetEmployees()
		//{
		//	return empData.GetData();
		//}
	}
}
