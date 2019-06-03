using AttendanceSystemDemo.BusinessLayer;
using AttendanceSystemDemo.Presenter;
using AttendanceSystemDemo.View;
using AttendanceSystemDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AttendanceSystemDemo
{
	public partial class Main : Form, ILoginView
	{
		private LoginPresenter _loginPresenter;

		public string EmployeeId
		{
			get => txtId.Text;
			set => txtId.Text = value;
		}

		public string Password
		{
			get => txtPassword.Text;
			set => txtPassword.Text = value;
		}

		public Main()
		{
			InitializeComponent();

			_loginPresenter = new LoginPresenter(this, new Logger());
		}

		private void Login(object sender, EventArgs e)
		{
			//_loginPresenter.Login();

			var empLoginViewModel = new EmployeeLoginViewModel
			{
				EmployeeId = EmployeeId,
				Password = Password
			};

			_loginPresenter.Login(empLoginViewModel);
		}

		private void Register(object sender, EventArgs e)
		{
			_loginPresenter.Register();
		}
	}
}
