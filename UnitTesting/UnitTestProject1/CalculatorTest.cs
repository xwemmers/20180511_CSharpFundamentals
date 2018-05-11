using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            Calculator c = new Calculator();

            int som = c.Add(2, 2);

            Assert.AreEqual(4, som);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Calculator c = new Calculator();

            int answer = c.Subtract(20, 5);

            Assert.AreEqual(15, answer);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Calculator c = new Calculator();

            int answer = c.Multiply(20, 5);

            Assert.AreEqual(100, answer);
        }

        [TestMethod]
        public void DivideTest()
        {
            Calculator c = new Calculator();

            int answer = c.Divide(20, 5);

            Assert.AreEqual(4, answer);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideTest2()
        {
            Calculator c = new Calculator();

            int answer = c.Divide(20, 0);

        }

    }
}
