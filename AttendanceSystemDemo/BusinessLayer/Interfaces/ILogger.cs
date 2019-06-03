using AttendanceSystemDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.BusinessLayer
{
	interface ILogger
	{
		void Login();
		void Register();
		//bool IsExisting();
		bool IsValidCredentials(EmployeeLoginViewModel empLoginViewModel);
		bool IsValidCredentials();

	}
}
