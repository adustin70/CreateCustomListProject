using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCustomList;

namespace MyCustomListUnitTestProject
{
    [TestClass]
    public class MinusOperatorOverloadMethodTest
    {
        [TestMethod]
        public void CustomListMinusOverload_CheckThatDoubleListIsRemoved()
        {
            // Arrange
            CustomList<double> list = new CustomList<double>();
            double testNumber = 65;
            double testNumber2 = 37;
            double testNumber3 = 56;

            CustomList<double> list2 = new CustomList<double>();
            double list2TestNumber = 23;
            double list2TestNumber2 = 46;

            CustomList<double> customList;

            CustomList<double> actual;
            string expected = "653756";

            // Act
            list.Add(testNumber);
            list.Add(testNumber2);
            list.Add(testNumber3);

            list2.Add(list2TestNumber);
            list2.Add(list2TestNumber2);

            customList = list + list2;

            actual = customList - list2;

            // Assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CustomListMinusOverload_CheckThatListIsRemoved()
        {
            // Arrange
            CustomList<double> list = new CustomList<double>();
            double testNumber = 5;

            CustomList<double> list2 = new CustomList<double>();
            double list2TestNumber = 3;

            CustomList<double> customList;

            CustomList<double> actual;
            string expected = "5";

            // Act
            list.Add(testNumber);
            list2.Add(list2TestNumber);

            customList = list + list2;

            actual = customList - list2;

            // Assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CustomListMinusOverload_CheckThatMultipleListAreRemoved()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int testNumber = 9;

            CustomList<int> list2 = new CustomList<int>();
            int list2TestNumber = 7;

            CustomList<int> customList;

            CustomList<int> actual;
            string expected = "9";

            // Act
            list.Add(testNumber);
            list2.Add(list2TestNumber);

            customList = list + list2;

            actual = customList - list2;

            // Assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CustomListMinusOverload_CheckThatListsOfDifferentSizesAreRemoved()
        {
            // Arrange
            CustomList<string> list1 = new CustomList<string>();
            string testString1 = "This";
            string testString2 = "Is";
            string testString3 = "Crazy";

            CustomList<string> list2 = new CustomList<string>();
            string list3TestString1 = "Remove";
            string list3TestString2 = "It";

            CustomList<string> customList;

            CustomList<string> actual;
            string expected = "ThisIsCrazy";

            // Act
            list1.Add(testString1);
            list1.Add(testString2);
            list1.Add(testString3);

            list2.Add(list3TestString1);
            list2.Add(list3TestString2);

            customList = list1 + list2;

            actual = customList - list2;

            // Assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CustomListMinusOverload_CheckThatAllListAreRemoved()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int testNumber = 9;

            CustomList<int> list2 = new CustomList<int>();
            int list2TestNumber = 6;

            CustomList<int> customList;

            CustomList<int> actual;
            string expected = "";

            // Act
            list.Add(testNumber);
            list2.Add(list2TestNumber);

            customList = list + list2;
            customList = customList - list2;

            actual = customList - list;

            // Assert
            Assert.AreEqual(expected, actual.ToString());
        }
    }
}
