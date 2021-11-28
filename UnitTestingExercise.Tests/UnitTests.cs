using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(4, 4, 2, 10)]
        [InlineData(3, 5, 6, 14)]
        [InlineData(50, 50, 20, 120)]
        [InlineData(-8, +10, +5, 7)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 10, 0)]
        [InlineData(10, 5, 5)]
        [InlineData(25, 10, 15)]
        [InlineData(15, 8, 7)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var test1 = new UnitTestMethods();

            //Act
            var actual = test1.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 3, 9)]
        [InlineData(3, 4, 16)]
        [InlineData(6, 7, 42)]
        [InlineData(-10, -50, 500)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();

            //Act
            var actual = test2.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);


        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(-100, -50, 2)]

        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();

            //Act
            var actual = test3.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void IsCharSymbol()
        {
            //Arrange
            var tester = new UnitTestMethods();
            string symbols = "$%~!^*";

            foreach (char character in symbols)
            {
                //Act
                bool actual = tester.IsCharSymbol(character);

                //Assert
                Assert.True(actual);
            }



        }

        [Fact]

        public void IsCharNotSymbol()
        {
            //Arrange
            var tester = new UnitTestMethods();
            string lettersAndNums = "0123456789abcdefghijklmnopqrstuvwxyz";

            foreach (char character in lettersAndNums)
            {
                //Act
                bool actual = tester.IsCharNotSymbol(character);

                //Assert
                Assert.True(actual);
            }
        }
        
    }
}