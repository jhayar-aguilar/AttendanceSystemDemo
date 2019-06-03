using AttendanceSystemDemo.Model;
using AttendanceSystemDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.Data
{
	class DailyTimeRecordData : IData<DailyTimeRecord>
	{
		private static List<DailyTimeRecord> dtrData = null;

		public DailyTimeRecordData()
		{
			if(dtrData == null)
			{
				dtrData = new List<DailyTimeRecord>
				{
					new DailyTimeRecord
					{
						Id = 1,
						EmployeeId = "ASD123",
						DateLoggedIn = "05/21/2019",
						Employee = new EmployeeData().GetData().SingleOrDefault(e => e.EmployeeId == "ASD123"),
						TimeLoggedIn = "10:00 AM",
						TimeLoggedOut = "10:10 AM",
					},
					new DailyTimeRecord
					{
						Id = 2,
						EmployeeId = "ASD123",
						DateLoggedIn = "05/20/2019",
						Employee = new EmployeeData().GetData().SingleOrDefault(e => e.EmployeeId == "ASD123"),
						TimeLoggedIn = "09:50 AM",
						TimeLoggedOut = "10:10 AM",
					},
					new DailyTimeRecord
					{
						Id = 3,
						EmployeeId = "ASD123",
						DateLoggedIn = "05/19/2019",
						Employee = new EmployeeData().GetData().SingleOrDefault(e => e.EmployeeId == "ASD123"),
						TimeLoggedIn = "10:02 AM",
						TimeLoggedOut = "10:10 AM",
					},
					new DailyTimeRecord
					{
						Id = 4,
						EmployeeId = "ASD123",
						DateLoggedIn = "05/18/2019",
						Employee = new EmployeeData().GetData().SingleOrDefault(e => e.EmployeeId == "ASD123"),
						TimeLoggedIn = "10:00 AM",
						TimeLoggedOut = "10:04 AM",
					},
				};
			}
		}

		public void AddData(DailyTimeRecord tData)
		{
			dtrData.Add(tData);
		}

		public List<DailyTimeRecord> GetData()
		{
			return dtrData
				.OrderBy(d => d.DateLoggedIn)
				.ToList();
		}

		public DailyTimeRecord GetItem(string id)
		{
			throw new NotImplementedException();
		}

		public bool IsIdAlreadyExists(string id)
		{
			throw new NotImplementedException();
		}

		public void UpdateData(string id)
		{
			//if (IsIdAlreadyExists())
			//{

			//}
		}
	}
}
