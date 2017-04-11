using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordRecycler
{
	public class PasswordChanger
	{
		private Action<string, int> _updateStatus;
		private Action<string> _exceptionHandler;
		private User _user;
		private int Iterations { get; set; }
		private int Start { get; set; }

		public PasswordChanger(User user, Action<string, int> updateStatus = null, Action<string> exceptionHandler = null, int start = 0, int iterations = 0)
		{
			_user = user;
			_updateStatus = updateStatus;
			_exceptionHandler = exceptionHandler;
			Start = start;
			Iterations = iterations;
		}

		public void StartJob(bool singleMode)
		{
			try
			{
				Connect();
				Task t;
				if (!singleMode)
				{
					t = new Task(ChangePasswordRecycleMode);
				}
				else
				{
					t = new Task(ChangePasswordSingleMode);
				}
				t.Start();
			}
			catch (Exception ex)
			{
				_updateStatus("Error!", -100);
				_exceptionHandler(ex.Message);
			}
		}

		public void Connect()
		{
			_user.Connect();
		}

		public void ChangePasswordSingleMode()
		{
			try
			{
				if (_user.NewPassword == _user.Password)
				{
					throw new Exception("Password must be different than the previous when in Single Mode.");
				}
				_updateStatus(null, 96);
				_user.ChangePassword(_user.NewPassword);
				_updateStatus("Success!", 100);
			}
			catch (Exception ex)
			{
				_updateStatus("Error!", -100);
				_exceptionHandler(ex.Message);
			}
		}

		public void ChangePasswordRecycleMode()
		{
			try
			{
				if (Iterations == 0)
					throw new Exception("Iterations must be set when recycling a password. \n\n(Choose the corresponding number of previous passwords kept by your domain)");

				try
				{
					for (int i = Start; i <= Iterations + Start - 1; i++)
					{
						_user.Connect();
						_user.ChangePassword(_user.NewPassword + "*" + i.ToString());
						System.Threading.Thread.Sleep(2000);//just to ensure the change has enough time on the server (I had problems without this once).
						_updateStatus("Iteration " + i.ToString() + " of " + Iterations + " (*" + i.ToString() + ")", 100 / Iterations);
					}
					_user.ChangePassword(_user.NewPassword);
				}
				catch (Exception ex)
				{
					if (_user.Password != null)
					{
						throw new Exception("An error occured, your current password is: "
							+ _user.Password
							+ "\n\nYou will most likely be locked out."
							+ "\nPlease contact your system administrator to get your account unlocked. Error Message: \n\n"
							+ ex.Message);
					}
					else
						throw ex;
				}
				_updateStatus("Success!", 100);
			}
			catch (Exception ex)
			{
				_updateStatus("Error!", -100);
				_exceptionHandler(ex.Message);
			}
		}
	}
}
