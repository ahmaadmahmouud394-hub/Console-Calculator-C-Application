using System;
using Xunit;
using System.IO;
using Moq;

namespace TestingCalculation
{
    public class UnitTest1
    {
        [Fact]
        public void  Test1()
        {
            int a = 6;
            int b = 7;
            var mockCalculator5 = new Mock<ICalcolo>();
            mockCalculator5.Setup(m => m.Sum(a,b)).Returns(13);
            var Calculator = new Calculator5(mockCalculator5.Object);
            var resultsum = Calculator.Sum(a,b);
            Assert.Equal(13, resultsum);

        }
        [Fact]
        public void Test2()
        {
            int a = 6;
            int b = 7;
            var mockCalculator5 = new Mock<ICalcolo>();
            mockCalculator5.Setup(m => m.Diffrence(a, b)).Returns(1);
            var Calculator = new Calculator5(mockCalculator5.Object);
            var resultDiffrence = Calculator.Diffrence(a, b);
            Assert.Equal(1, resultDiffrence);
        }
        [Fact]
        public void Test3() 
        {
            int a = 6;
            int b = 7;
            var mockCalculator5 = new Mock<ICalcolo>();
            mockCalculator5.Setup(m => m.Multiplication(a, b)).Returns(42);
            var Calculator = new Calculator5(mockCalculator5.Object);
            var resultMultiplication = Calculator.Multiplication(a, b);
            Assert.Equal(42, resultMultiplication);


        }
        [Fact]
        public void Test4()
        {
            int a = 6;
            int b = 7;
            var mockCalculator5 = new Mock<ICalcolo>();
            mockCalculator5.Setup(m => m.Division(a, b)).Returns(0.8571428571428571);
            var Calculator = new Calculator5(mockCalculator5.Object);
            var resultDivision = Calculator.Division(a, b);
            Assert.Equal(0.8571428571428571, resultDivision);
        }
    }
}