using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace MsTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ///Arrange
            string pwd = "rasipendela";
            string expected = "valid";
            Registration register = new Registration(pwd);
            ///Act
            string actual = register.ValidatingPassword();
            ///Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
