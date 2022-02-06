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
            string mobile = "+91 8975675345";
            string expected = "valid";
            Registration register = new Registration(mobile);
            ///Act
            string actual = register.ValidatingMobileNum();
            ///Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
