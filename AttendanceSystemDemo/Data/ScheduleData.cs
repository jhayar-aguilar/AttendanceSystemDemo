using AttendanceSystemDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystemDemo.Data
{
	class ScheduleData : IData<Schedule>
	{
		private static List<Schedule> scheduleData = null;

		public void AddData(Schedule tData)
		{
			scheduleData.Add(tData);
		}

		public List<Schedule> GetData()
		{
			if(scheduleData == null)
			{
				scheduleData = new List<Schedule>
				{
					new Schedule
					{
						Id = 1,
						StartTime = DateTime.Today.Add(new TimeSpan(5, 0, 0)).ToString("hh:mm tt"),
						EndTime = DateTime.Today.Add(new TimeSpan(14, 0, 0)).ToString("hh:mm tt"),
					},
					new Schedule
					{
						Id = 2,
						Type = "8a5p",
						StartTime = DateTime.Today.Add(new TimeSpan(8, 0, 0)).ToString("hh:mm:ss tt"),
						EndTime = DateTime.Today.Add(new TimeSpan(17, 0, 0)).ToString("hh:mm:ss tt"),
					},
					new Schedule
					{
						Id = 3,
						Type = "10a11a",
						StartTime = DateTime.Today.Add(new TimeSpan(10, 0, 0)).ToString("hh:mm:ss tt"),
						EndTime = DateTime.Today.Add(new TimeSpan(10, 5, 0)).ToString("hh:mm:ss tt"),
					}
				};
			}

			return scheduleData;
		}

		public Schedule GetItem(string id)
		{
			return GetData().SingleOrDefault(e => e.Type == id);
		}

		public bool IsIdAlreadyExists(string id)
		{
			throw new NotImplementedException();
		}

		public void UpdateData(string id)
		{
			throw new NotImplementedException();
		}
	}
}
