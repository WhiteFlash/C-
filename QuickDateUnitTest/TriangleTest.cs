using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickDate.Classes;
using System;

namespace QuickDateUnitTest
{
    [TestClass]
    public class TriengleTest
    {
        [TestMethod]
        public void CheckNumberTest()
        {
            //Arrange
            int[] expected = { 1, 2, 3 };
            var triangle_object = new Triangle();
            var actual = triangle_object.CheckNumber(1, 3, 2);

            //Assert
            CollectionAssert.AreEqual(expected, actual, $"Incorrect calues inside of array");
        }

        [TestMethod]
        public void Check_Property()
        {
            //Arrenge
            var triangle = new Triangle();
            var expected = 5;
            triangle.A = 5;

            //Assert
            Assert.AreEqual(expected, triangle.A, "Not equal");
        }

        [TestMethod]
        public void Check_Existing_Method()
        {
            //Arrenge
            var triangle = new Triangle(2,2,3);
            var expexted = true;
            var actual = triangle.CheckExisting();

            //Assert
            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void Check_GetToKnowType_Test()
        {
            var triangle = new Triangle(3, 4, 5);
            var expected = "Right-angled";
            var actual = triangle.GetToKnowType(3, 4, 5);

            Assert.AreEqual(expected, actual);

        }
    }
}
