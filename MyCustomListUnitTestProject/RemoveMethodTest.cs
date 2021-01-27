using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCustomList;

namespace MyCustomListUnitTestProject
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void RemoveItemFromCustomList_CheckCountEquals0()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string randomItem = "Computer";
            int actual;
            int expected = 0;

            // Act
            list.Add(randomItem);
            list.Remove(randomItem);
            actual = list.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void RemoveItemsFromCustomList_CheckCountEquals1()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int testNumber = 24;
            int testNumber1 = 25;
            int testNumber2 = 84;
            int testNumber3 = 1;
            int actual;
            int expected = 1;

            // Act
            list.Add(testNumber);
            list.Add(testNumber1);
            list.Add(testNumber2);
            list.Add(testNumber3);

            list.Remove(testNumber1);
            list.Remove(testNumber2);
            list.Remove(testNumber3);

            actual = list.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void RemoveItemFromCustomList_CheckItemAtIndex2()
        {
            // Arrange
            CustomList<double> list = new CustomList<double>();
            double doubleNumber = 4.5;
            double doubleNumber1 = 5.8;
            double doubleNumber2 = 8.6;
            double doubleNumber3 = 1.0;
            double actual;
            double expected = doubleNumber3;

            // Act
            list.Add(doubleNumber);
            list.Add(doubleNumber1);
            list.Add(doubleNumber2);
            list.Add(doubleNumber3);

            list.Remove(doubleNumber1);

            actual = list[2];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void RemoveItemFromCustomList_CheckItemAtIndex6()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string testString = "This";
            string testString1 = "Coding";
            string testString2 = "Stuff";
            string testString3 = "Is";
            string testString4 = "The";
            string testString5 = "Bees";
            string testString6 = "Knees";
            string testString7 = "!";
            string actual;
            string expected = "Knees";

            // Act
            list.Add(testString);
            list.Add(testString1);
            list.Add(testString2);
            list.Add(testString3);
            list.Add(testString4);
            list.Add(testString5);
            list.Add(testString6);
            list.Add(testString7);

            list.Remove(testString7);

            actual = list[6];


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void RemoveItemsFromCustomList_CheckItemAtIndex2()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string testString = "This";
            string testString1 = "Coding";
            string testString2 = "Stuff";
            string testString3 = "Is";
            string testString4 = "The";
            string testString5 = "Bees";
            string testString6 = "Knees";
            string testString7 = "!";
            string actual;
            string expected = "Is";

            // Act
            list.Add(testString);
            list.Add(testString1);
            list.Add(testString2);
            list.Add(testString3);
            list.Add(testString4);
            list.Add(testString5);
            list.Add(testString6);
            list.Add(testString7);

            list.Remove(testString4);
            list.Remove(testString2);
            list.Remove(testString5);
            list.Remove(testString7);


            actual = list[2];


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
