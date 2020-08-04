using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using QuickDate.Classes;

namespace QuickDateUnitTest
{
    [TestClass]
    public class EfficientJanitorTest
    {

        [TestMethod]
        public void CompareDigitsCheck()
        {
            //Arange
            bool expected = true;
            bool actual = EfficientJanitor.CompareDigits(1.5f, 1.5f);

            //Assert
            Assert.AreEqual(expected, actual, $"Actual {actual} is not equal to expected {expected}");
        }

        [TestMethod]
        public void HowMuchLeftCheck()
        {
            var expected = 0.1f;
            float actual = (float)Math.Round(EfficientJanitor.HowMuchLeft(2.9f), 2);

            Assert.AreEqual(expected, actual, $"Expected { expected } != actual { actual }");


        }

        [TestMethod]
        public void SearchCheck()
        {
            float[] expected = new float[] { 1.2f, 1.4f, 0.4f };
            var array = new float[] { 1.2f, 1.4f, 0.4f, 2.9f };
            float[] actual = EfficientJanitor.Search(array, 1.5f);

            CollectionAssert.AreEqual(expected, actual, $"Elements are not the same");


        }
    }
}
