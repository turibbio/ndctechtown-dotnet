using NUnit.Framework;

namespace CalculatorApp.Tests
{
    public class Tests
    {
        [Test]
        public void SumTest()
        {
            int a = 2;
            int b = 3;
            int expectedResult = 5;

            var result = new Calculator().Sum(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]        
        public void SubTest()
        {
            int a = 3;
            int b = 2;
            int expectedResult = 1;

            var result = new Calculator().Sub(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void MultiplyTest()
        {
            int a = 3;
            int b = 2;
            int expectedResult = 6;

            var result = new Calculator().Multiply(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void DivideTest()
        {
            int a = 6;
            int b = 2;
            int expectedResult = 3;

            var result = new Calculator().Divide(a, b);

            Assert.AreEqual(expectedResult, result);
        }
    }
}