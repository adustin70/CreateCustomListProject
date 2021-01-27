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
            string expected = "???";

            // Act
            list.Add(intToString);
            list.ConvertToString();
            actual = list.ConvertToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListConvertToString_CheckThatListDoubleConvertsToString()
        {
            // Arrange
            CustomList<double> list = new CustomList<double>();
            double doubleToString = 556;
            string actual;
            string expected = "???";

            // Act
            list.Add(doubleToString);
            list.ConvertToString();
            actual = list.ConvertToString();

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
            string expected = "???";

            // Act
            list.Add(intToString);
            list.Add(intToString1);
            list.Add(intToString2);
            list.Add(intToString3);

            list.ConvertToString();
            actual = list.ConvertToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListToString_CheckThatListStringDoesNotConvert()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string testString = "This";
            string testString1 = "Is";
            string testString2 = "Challenging";
            string actual;
            string expected = "???";

            // Act
            list.Add(testString);
            list.Add(testString1);
            list.Add(testString2);
            list.Add(testString3);

            list.ConvertToString();
            actual = "???";

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListConvertToString_CheckThatListDecimalConvertsToString()
        {
            // Arrange
            CustomList<decimal> list = new CustomList<decimal>();
            decimal testNum = 2.0;
            string actual;
            string expected = "???";

            // Act
            list.Add(testNum);
            list.ConvertToString();
            actual = list.ConvertToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
