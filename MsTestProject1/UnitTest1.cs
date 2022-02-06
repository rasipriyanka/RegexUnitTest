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
            string email = "rasi.priyanka@bridgelabz.com";
            string expected = "valid";
            Registration register = new Registration(email);
            ///Act
            string actual = register.ValidatingEmail();
            ///Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
