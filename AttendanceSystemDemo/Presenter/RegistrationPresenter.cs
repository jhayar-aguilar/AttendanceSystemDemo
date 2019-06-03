using AttendanceSystemDemo.Data;
using AttendanceSystemDemo.Model;
using AttendanceSystemDemo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystemDemo.Presenter
{
	class RegistrationPresenter
	{
		private Form _form;
		//private ILogger logger;

		public RegistrationPresenter(Form form)
		{
			_form = form;
		}

		public void Register(Employee newEmployee)
		{
			new EmployeeData().AddData(newEmployee);

			MessageBox.Show("Registration successful");

			//new EmployeeData().AddData(new Employee
			//{
			//	EmployeeId = "QWE123",
			//	FirstName = "qwe",
			//	LastName = "ewq",
			//	Password = "qwe123",
			//	ScheduleType = "5a2p",
			//	Schedule = new ScheduleData().GetData().SingleOrDefault(s => s.Type == "5a2p")
			//});
		}
	}
}
