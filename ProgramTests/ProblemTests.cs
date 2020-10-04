using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;
using System;
namespace ProgramTests
{
    [TestClass]
    public class ProblemTests
    {
        [TestMethod]
        public void Test_ReverseString()
        {
            //Arrange
            string input = "abcd";
            string expected = "dcba";
            Problems problems = new Problems();
            var actual = problems.ReverseString(input);
            //Act
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch(Exception ex)
            {
                StringAssert.Contains(ex.Message, input);
            }
        }
    }
}
