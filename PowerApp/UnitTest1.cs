using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerApp;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Power_App app = new Power_App(2, 6);

            int expected = 64;

            int result = app.CalculatePower();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {

            Power_App app = new Power_App(2/3, 6/2);

            double expected = 0.287;

            int result = app.CalculatePower();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {

            Power_App app = new Power_App(0,10);

            double expected = 0;

            int result = app.CalculatePower();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {

            Power_App app = new Power_App(9999, 9999);

            string expected = null;

            int result = app.CalculatePower();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {

            Power_App app = new Power_App(1, 10);

            double expected = 1;

            int result = app.CalculatePower();

            Assert.AreEqual(expected, result);
        }
    }
}