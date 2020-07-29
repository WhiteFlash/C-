using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using QuickDate.Classes;

namespace QuickDateUnitTest
{
    [TestClass]
    public class PlusMinusTest
    {
        [TestMethod]
        public void plusMinusTest()
        {
            //Arrange
            string[] expected = { "0.333333", "0.333333", "0.333333" };
            int[] toPass = { 1, -1, 0 };
            var actual = PlusMinus.plusMinus(toPass);

            //Assert
            CollectionAssert.AreEqual(expected, actual, $"Incorrect calues inside of array");
        }
    }
}
