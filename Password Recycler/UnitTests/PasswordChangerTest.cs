using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.MockObjects;
using PasswordRecycler;

namespace UnitTests
{
    [TestClass]
    public class PasswordChangerTest
    {
        Action<string, int> update = delegate(string status, int progress)
        {
            //do nothing
        };
        Action<string> errorHandle = delegate(string message)
        {
            throw new Exception(message);
        };

        [TestMethod]
        public void TestSingleMode()
        {
            MockUser user = new MockUser("TestUser", "TestPassword", "MyNewPassword");
            
            PasswordChanger pc = new PasswordChanger(user, update, errorHandle);
            pc.ChangePasswordSingleMode();
            Assert.AreEqual(user.NewPassword, user.Password);
        }

        [TestMethod]
        public void TestRecycleMode()
        {
            MockUser user = new MockUser("TestUser", "TestPassword", "MyNewPassword");

            PasswordChanger pc = new PasswordChanger(user, update, errorHandle, 1, 2);
            pc.ChangePasswordRecycleMode();
            Assert.AreEqual(user.NewPassword, user.Password);
        }

        [TestMethod]
        public void TestRecycleModeNoIterations()
        {
            MockUser user = new MockUser("TestUser", "TestPassword", "MyNewPassword");

            PasswordChanger pc = new PasswordChanger(user, update, errorHandle);
            try
            {
                pc.ChangePasswordRecycleMode();
            }
            catch (Exception ex)
            {
                string expected = "Iterations must be set when recycling a password. \n\n(Choose the corresponding number of previous passwords kept by your domain)";
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void TestRecycleModeFailDuringRecycle()
        {
            MockUserWithChangeErrorOnThirdAttempt user = new MockUserWithChangeErrorOnThirdAttempt("TestUser", "TestPassword", "MyNewPassword");

            PasswordChanger pc = new PasswordChanger(user, update, errorHandle, 1, 4);
            try
            {
                pc.ChangePasswordRecycleMode();
            }
            catch (Exception ex)
            {
                string expected = "An error occured, your current password is: "
                            + "MyNewPassword*2"
                            + "\n\nYou will most likely be locked out."
                            + "\nPlease contact your system administrator to get your account unlocked. Error Message: \n\n"
                            + "Unit Test";
                //assert that the expected exeption was thrown
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
