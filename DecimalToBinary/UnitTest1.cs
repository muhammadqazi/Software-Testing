using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecimalToBinary;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Decimal_To_Binary d = new Decimal_To_Binary(12);

            int expected = 1100;

            int result = int.Parse(d.Convert());

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Decimal_To_Binary d = new Decimal_To_Binary(22);

            int expected = 10110;

            int result = int.Parse(d.Convert());

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMethod3()
        {
            Decimal_To_Binary d = new Decimal_To_Binary(22/5);

            int expected = 10110;

            int result = int.Parse(d.Convert());

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMethod4()
        {
            Decimal_To_Binary d = new Decimal_To_Binary(1000);

            int expected = 1111101000;

            int result = int.Parse(d.Convert());

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMethod5()
        {
            Decimal_To_Binary d = new Decimal_To_Binary(12/5);

            int expected = 1100;

            int result = int.Parse(d.Convert());

            Assert.AreEqual(expected, result);

        }
    }
}