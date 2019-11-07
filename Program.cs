using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTesting
{
    public class Program
    {
        public int addNumber(int a, int b)
        {
            return a + b;
        }
        [Fact]
        public void AddNumbers_ReturnsZero_Value1_Zero()
        {
            // Arrange - setting up all the input, dependencies, testData (expected output)
            int value1 = 0;
            int value2 = 3;
            int expectedOutput = 3;

            // Act - Call the actual method/code
            var actual = addNumber(value1, value2);

            // Assert - test expected-actual
            Assert.Equal(expectedOutput, actual);
        }
    }
}
