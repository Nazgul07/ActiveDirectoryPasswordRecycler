using PasswordRecycler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.MockObjects
{
    public class MockUserWithChangeErrorOnThirdAttempt : User
    {
        public MockUserWithChangeErrorOnThirdAttempt(string username = null, string password = null, string newPassword = null, string domain = null, string dn = null)
        {
            Username = username;
            Password = password;
            NewPassword = newPassword;
            Domain = domain;
            DN = dn;
        }

        public override void ChangePassword(string newPassword)
        {
            if (newPassword.Contains("3"))
            {
                throw new Exception("Unit Test");
            }
            Password = newPassword;
        }
        public override void Connect()
        {
        }
    }
}
