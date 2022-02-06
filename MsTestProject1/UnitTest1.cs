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
            string specialchar = "RasiPriyanka@12";
            string expected = "valid";
            Registration register = new Registration(specialchar);
            ///Act
            string actual = register.Validatingspecialchar();
            ///Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
