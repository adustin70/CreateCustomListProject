using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCustomList;
using System.Collections;
using System.Collections.Generic;

namespace MyCustomListUnitTestProject
{
    [TestClass]
    public class AddMethodTest
    {
        [TestMethod]
        public void AddItemToCustomList_CheckCountEquals1()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
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

        public void AddItemToCustomList_CheckCountEquals5()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string myThoughts1 = "I";
            string myThoughts2 = "Love";
            string myThoughts3 = "Learning";
            string myThoughts4 = "To";
            string myThoughts5 = "Code";
            int actual;
            int expected = 5;

            // Act
            list.Add(myThoughts1);
            list.Add(myThoughts2);
            list.Add(myThoughts3);
            list.Add(myThoughts4);
            list.Add(myThoughts5);
            actual = list.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemToCustomList_CheckForItemAtIndex0()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "Smith";
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
            CustomList<string> list = new CustomList<string>();
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

        public void AddItemToCustomList_CheckForItemValue()
        {
            // Arrange
           
            CustomList<int> list = new CustomList<int>();
            int myAge = 31;
            int actual;
            int expected = 31;

            // Act
            list.Add(myAge);
            actual = list[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]

        public void AddItemToCustomList_CheckCapacityUponCreation_CapacityShouldBeFour()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int actual;
            int expected = 4;

            // Act

            actual = list.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemToCustomList_ExceedingInitialCapacity_CapacityShouldBeDouble()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int valueOne = 2;
            int valueTwo = 4;
            int valueThree = 7;
            int valueFour = 9;
            int valueFive = 6;
            int actual;
            int expected = 8;




            // Act
            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Add(valueFour);
            list.Add(valueFive);
            actual = list.Capacity;


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemToCustomList_CheckForItemAtIndexTwo_IndexShouldBeSameAsBeforeCopy()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int valueOne = 2;
            int valueTwo = 4;
            int valueThree = 7;
            int valueFour = 9;
            int valueFive = 6;
            int actual;
            int expected = valueThree;

            // Act
            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Add(valueFour);
            list.Add(valueFive);
            actual = list[2];

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
