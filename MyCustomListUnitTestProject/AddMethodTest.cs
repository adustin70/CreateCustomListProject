using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCustomList;

namespace MyCustomListUnitTestProject
{
    [TestClass]
    public class AddMethodTest
    {
        [TestMethod]
        public void AddItemToCustomList_CheckCountEquals1()
        {
            // Arrange
            CustomList list = new CustomList();
            string shoe = "Air Jordans";
            int actual;
            int expected = 1;

            // Act
            list.Add(shoe);
            actual = list.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemToCustomList_CheckForItemAtIndex0()
        {
            // Arrange
            CustomList list = new CustomList();
            string expected = "Pippin";
            string actual;

            // Act
            list.Add(expected);
            actual = list[0];

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemsToCustomList_CheckForItemAtIndex3()
        {
            // Arrange
            CustomList list = new CustomList();
            string name1 = "Stephon";
            string name2 = "Marbella";
            string name3 = "JT";
            string name4 = "Rob";
            string expected = "Rob";
            string actual;

            // Act
            list.Add(name1);
            list.Add(name2);
            list.Add(name3);
            list.Add(name4);

            actual = list[3];

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemToCustomList_CheckForItemDataType()
        {
            // Arrange
            CustomList list = new CustomList();
            int myAge = 31;
            int actual;
            int expected = myAge;

            // Act
            list.Add(myAge);
            actual = list.GetType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemsToCustomList_CheckForItemDataType2()
        {
            // Arrange
            CustomList list = new CustomList();
            string bestToJumpFrom = "Black Hawk";
            int nightJumps = 3;
            double totalJumps = 25;
            double actual;
            double expected = totalJumps;

            // Act
            list.Add(bestToJumpFrom);
            list.Add(nightJumps);
            list.Add(totalJumps);
            actual = list.GetType(list[2]);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
