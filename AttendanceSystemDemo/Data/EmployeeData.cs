using AttendanceSystemDemo.Model;
using AttendanceSystemDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.Data
{
	class EmployeeData : IData<Employee>
	{
		private static List<Employee> empData = null;

		public EmployeeData()
		{
			if (empData == null)
			{
				empData = new List<Employee>
				{
					new Employee
					{
						Id = 1,
						EmployeeId = "ASD123",
						FirstName = "asd",
						LastName = "dsa",
						Password = "asd123",
						HasTimeLoggedIn = false,
						//ScheduleType = "10a11a",
						ScheduleId = 3,
						Schedule = new ScheduleData().GetData().SingleOrDefault(s => s.Id == 3)
					},
					new Employee
					{
						Id = 2,
						EmployeeId = "DSA123",
						FirstName = "dsa",
						LastName = "asd",
						Password = "dsa123",
						HasTimeLoggedIn = false,
						//ScheduleType = "8a5p",
						ScheduleId = 2,
						Schedule = new ScheduleData().GetData().SingleOrDefault(s => s.Id == 2)
					}
				};
			}

		}

		public void AddData(Employee tData)
		{
			empData.Add(tData);
		}

		public List<Employee> GetData()
		{
			return empData;

			//EmployeeDetails = {
			//EmployeeId = "ASD123", FirstName = "asd", LastName = "dsa", Password = "asd123"
			//		}
		}

		public Employee GetItem(string id)
		{
			return GetData().SingleOrDefault(e => e.EmployeeId == id);
		}

		public bool IsIdAlreadyExists(string id)
		{
			return GetData().Any(e => e.EmployeeId == id);
		}

		public void UpdateData(string id)
		{
			if (IsIdAlreadyExists(id))
			{
				var emp = GetItem(id);

				var idx = GetData().IndexOf(emp);

				GetData()[idx] = emp;
			}
		}
	}
}
