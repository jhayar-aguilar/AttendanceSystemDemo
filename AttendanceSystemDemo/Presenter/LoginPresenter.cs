using AttendanceSystemDemo.BusinessLayer;
using AttendanceSystemDemo.Data;
using AttendanceSystemDemo.Model;
using AttendanceSystemDemo.View;
using AttendanceSystemDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystemDemo.Presenter
{
	class LoginPresenter
	{
		//private Form _mainForm;
		private ILogger _logger;
		private ILoginView _loginView;

		public LoginPresenter(ILoginView loginView, ILogger logger)
		{
			//_mainForm = mainForm;
			_logger = logger;
			_loginView = loginView;
		}

		public void Register()
		{
			if (_loginView is Main form)
			{
				form.Close();

				Thread th = new Thread(() => Application.Run(new Registration()));
				th.Start();
			}
		}

		//public void Login()
		//{
		//	Employee emp = new Employee
		//	{
		//		EmployeeId = _loginView.EmployeeId,
		//		Password = _loginView.Password
		//	};

		//	var form = _loginView as Main;

		//	if (form != null)
		//	{
		//		if (_logger.IsValidCredentials())
		//		{
		//			form.Close();

		//			Thread th = new Thread(() => Application.Run(new Dashboard()));
		//			th.Start();
		//		}
		//	}
		//	else
		//		MessageBox.Show("Invalid credentials");
		//}

		public void Login(EmployeeLoginViewModel empLoginViewModel)
		{
			if (_logger.IsValidCredentials(empLoginViewModel))
			{
				if (_loginView is Main form)
				{
					form.Close();

					var emp = new EmployeeData().GetItem(empLoginViewModel.EmployeeId);

					Thread th = new Thread
						(() => Application.Run(new Dashboard(emp)));

					th.Start();
				}
			}
			else
				MessageBox.Show("Invalid credentials");
		}
	}
}
