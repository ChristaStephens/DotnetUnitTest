// using System.Collections.Generic;
// using Xunit;

// namespace RMServicingApi.Tests.Repositories
// {
//     public class Test
//     {
//         public class Values
//         {
//             //models
//             public int ValueOne { get; set; }
//             public int ValueTwo { get; set; }
//         }
//         public int AddNumbers(int a, int b)
//         {
//             if(a == 0 || b == 0)
//             {
//                 return 0;
//             }
//             return a+b;
//         }

//         [Fact(Skip="")]
//         public void AddNumbers_ReturnsSum()
//         {
//             // Arrange - setting up all the input, dependencies, testData (expected output)
//             int value1 = 1;
//             int value2 = 2;
//             int expectedOutput = 3;

//             // Act - Call the actual method/code
//             var actual = AddNumbers(value1, value2);

//             // Assert - test expected-actual
//             Assert.Equal(expectedOutput, actual);
//         }

//         [Fact]
//         public void AddNumbers_ReturnsZero_Value1_Zero()
//         {
//             // Arrange - setting up all the input, dependencies, testData (expected output)
//             int value1 = 0;
//             int value2 = 2;
//             int expectedOutput = 0;

//             // Act - Call the actual method/code
//             var actual = AddNumbers(value1, value2);

//             // Assert - test expected-actual
//             //sev api contact us repository
//             Assert.Equal(expectedOutput, actual);
//         }

//         [Theory]
//         [InlineData(1,2,3)]
//         [InlineData(0,1,0)]
//         public void AddNumbers_ReturnsSum_Theory(int value1, int value2, int expectedOutput)
//         {
//             // Arrange - setting up all the input, dependencies, testData (expected output)
//             // we have all the setup in the InlineData, no arrange required here

//             // Act - Call the actual method/code
//             var actual = AddNumbers(value1, value2);

//             // Assert - test expected-actual
//             Assert.Equal(expectedOutput, actual);
//         }

//         #region MemberData

//         // Method that takes an object for input
//         public int AddNumbersFromObject(Values values)
//         {
//             if (values.ValueOne == 0 || values.ValueTwo == 0)
//             {
//                 return 0;
//             }
//             return values.ValueOne + values.ValueTwo;
//         }

//         // Member data is used for object and to run the same test with different inputs and outputs
//         public static IEnumerable<object[]> multipleTestData()
//         {
//             yield return new object[] { new Values() { ValueOne = 1, ValueTwo = 2 }, 3 };
//             yield return new object[] { new Values() { ValueOne = 0, ValueTwo = 2 }, 0 };
//             yield return new object[] { new Values() { ValueOne = 1, ValueTwo = 0 }, 0 };
//         }

//         [Fact]
//         public void AddNumbers_ReturnsSum_Values_Object_Single_Test()
//         {
//             // Arrange - setting up all the input, dependencies, testData (expected output)
//             Values values = new Values() { ValueOne = 3, ValueTwo = 5 };
//             int expectedOutput = 8;

//             // Act - Call the actual method/code
//             var actual = AddNumbersFromObject(values);

//             // Assert - test expected-actual
//             Assert.Equal(expectedOutput, actual);
//         }

//         [Theory]
//         [MemberData(nameof(multipleTestData))]
//         public void AddNumbers_ReturnsSum_Theory_MemberData(Values values, int expectedOutput)
//         {
//             // Arrange - setting up all the input, dependencies, testData (expected output)

//             // Act - Call the actual method/code
//             var actual = AddNumbersFromObject(values);

//             // Assert - test expected-actual
//             Assert.Equal(expectedOutput, actual);
//         }
//         #endregion
//     }
// }
