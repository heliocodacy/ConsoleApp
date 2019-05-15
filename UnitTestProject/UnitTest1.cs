using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Utils u = new Utils();
            Assert.AreEqual(5, u.Sum(2, 3));
        }
    }
}
