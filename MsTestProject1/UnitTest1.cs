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
            string upper = "RasiPriyanka";
            string expected = "valid";
            Registration register = new Registration(upper);
            ///Act
            string actual = register.ValidatingUpperCase();
            ///Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
