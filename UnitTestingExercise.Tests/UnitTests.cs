using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20, 10, 10)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new UnitTestMethods();
            //Act
            var actual = tester.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20, 33, 660)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {

            var testing = new UnitTestMethods();

            var actual = testing.Multiply(num1, num2);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(33, 11, 3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var tests = new UnitTestMethods();  
            //Act
            var actual = tests.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
