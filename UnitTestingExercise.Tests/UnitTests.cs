using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]//Add test data <-------
        [InlineData(3,3,3,9)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:


            //Arrange
            // create a Calculator object
            var sm = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = sm.Add(num1,num2,num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
                      //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:


            //Arrange
            var subt = new Calculator();
            //Act
            var actual = subt.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,3,15)]//Add test data <-------
       public void MultiplyTest(int num1, int num2, int expected)
       {
            //Start Step 7 here:




            //Arrange
            var multi = new Calculator();


            //Act
            var actual = multi.Mutiply(num1, num2);



            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20,5,4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)



      {

            var divide = new Calculator();

            //Arrange

            //Act
            var actual = divide.Divide(num1, num2);


            //Assert
            Assert.Equal(expected, actual);

        }

    }
}