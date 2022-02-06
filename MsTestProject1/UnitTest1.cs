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
            string lastName = "Priyanka";
            string expected = "valid";
            Registration register = new Registration(lastName);
            ///Act
            string actual = register.ValidatingLastName();
            ///Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
