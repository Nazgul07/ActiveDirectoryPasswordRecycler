using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;

namespace PasswordRecycler
{
	public class User
	{
		private UserPrincipal _directoryUser;

		public string Domain { get; set; }
		public string DN { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string NewPassword { get; set; }

		public User(string username = null, string password = null, string newPassword = null, string domain = null, string dn = null)
		{
			Username = username;
			Password = password;
			NewPassword = newPassword;
			Domain = domain;
			DN = dn;
		}

		public virtual void Connect()
		{
			PrincipalContext adPrincipalContext = new PrincipalContext(ContextType.Domain, Domain, DN, ContextOptions.Negotiate, Username, Password);
			_directoryUser = UserPrincipal.FindByIdentity(adPrincipalContext, Username);
			if (_directoryUser == null) throw new Exception("User not found in Active Directory");
		}

		public virtual void ChangePassword(string newPassword)
		{
			_directoryUser.ChangePassword(Password, newPassword);
			Password = newPassword;
		}
	}
}
