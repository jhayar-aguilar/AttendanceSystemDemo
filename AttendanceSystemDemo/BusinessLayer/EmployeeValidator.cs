using AttendanceSystemDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.BusinessLayer
{
	class EmployeeValidator : IValidator<Employee>
	{
		public bool IsIdExists(Employee TClass)
		{
			throw new NotImplementedException();
		}
	}
}
