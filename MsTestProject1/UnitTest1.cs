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
            string firstName = "Rasi";
            string expected = "valid";
            Registration register = new Registration(firstName);
            ///Act
            string actual = register.ValidatingFirstName();
            ///Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
