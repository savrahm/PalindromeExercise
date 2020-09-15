using PalindromeExercise;
using System;
using System.ComponentModel;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("neveroddoreven",true)]
        [InlineData("hello",false)]
        [InlineData("natal",false)]
        public void Test1(string str, bool expected)
        {
            //Arrange
            var test = new WordSmith();

            //Act
            var actual = test.IsAPalindrome(str);

            //Assert
            Assert.Equal(actual, expected);

        }
    }
}
