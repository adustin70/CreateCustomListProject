using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCustomList;

namespace MyCustomListUnitTestProject
{
    [TestClass]
    public class ToStringMethodTest
    {
        [TestMethod]
        public void CustomListConvertToString_CheckThatListIntConvertsToString()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int intToString = 5;
            string actual;
            string expected = "5";

            // Act
            list.Add(intToString);

            actual = list.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListConvertToString_CheckThatListDoubleConvertsToString()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int doubleToString = 556;
            string actual;
            string expected = "556";

            // Act
            list.Add(doubleToString);

            actual = list.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListConvertToString_ConvertListToString()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int intToString = 56;
            int intToString1 = 23;
            int intToString2 = 87;
            int intToString3 = 3;

            string actual;
            string expected = "5623873";

            // Act
            list.Add(intToString);
            list.Add(intToString1);
            list.Add(intToString2);
            list.Add(intToString3);

            
            actual = list.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListConvertToString_CheckThatListDecimalConvertsToString()
        {
            // Arrange
            CustomList<decimal> list = new CustomList<decimal>();
            decimal testNum = 2.0m;
            string actual;
            string expected = "2.0";

            // Act
            list.Add(testNum);

            actual = list.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void CustomListConvertToString_CheckThatNegativeIntConvertsToString()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int intToString = -5;
            string actual;
            string expected = "-5";

            // Act
            list.Add(intToString);

            actual = list.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
