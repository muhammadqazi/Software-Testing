using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {

            Calculator_app cal = new Calculator_app(10,10);

            int expectedValue = 20;

            float result = cal.Add();

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void TestMethod2()
        {

            Calculator_app cal = new Calculator_app(10, 10);

            int expectedValue = 0;

            float result = cal.Subtract();

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void TestMethod3()
        {

            Calculator_app cal = new Calculator_app(10, 10);

            int expectedValue = 100;

            float result = cal.Multiply();

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void TestMethod4()
        {

            Calculator_app cal = new Calculator_app(10, 10);

            int expectedValue = 1;

            float result = cal.Divide();

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void TestMethod5()
        {

            Calculator_app cal = new Calculator_app(10, 10);

            int expectedValue = 12;

            float result = cal.Multiply();

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void TestMethod6()
        {

            Calculator_app cal = new Calculator_app(10, 10);

            int expectedValue = 12;

            float result = cal.Add();

            Assert.AreEqual(expectedValue, result);
        }
    }
}