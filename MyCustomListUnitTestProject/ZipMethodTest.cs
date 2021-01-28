using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCustomList;

namespace MyCustomListUnitTestProject
{
    [TestClass]
    public class ZipMethodTest
    {
        [TestMethod]
        public void CustomListZip_CheckThatItemIsAtCorrectIndex()
        {
            // Arrange
            CustomList<int> zipList1 = new CustomList<int>();
            int testZipNumber1 = 2;
            int testZipNumber2 = 8;

            CustomList<int> zipList2 = new CustomList<int>();
            int list2ZipNumber1 = 4;
            int list2ZipNumber2 = 6;

            CustomList<int> newZipList = zipList1.Zip(zipList2);

            int actual;
            int expected = 4;

            // Act
            zipList1.Add(testZipNumber1);
            zipList1.Add(testZipNumber2);

            zipList2.Add(list2ZipNumber1);
            zipList2.Add(list2ZipNumber2);

            actual = newZipList[1];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListZip_CheckThatItemsAreAddedCorrectly()
        {
            // Arrange
            CustomList<int> zipList1 = new CustomList<int>();
            int testZipNumber1 = 1;
            int testZipNumber2 = 3;

            CustomList<int> zipList2 = new CustomList<int>();
            int list2ZipNumber1 = 2;
            int list2ZipNumber2 = 4;

            CustomList<int> newZipList = zipList1.Zip(zipList2);

            CustomList<int> actual;
            CustomList<int> expected = newZipList;

            // Act
            zipList1.Add(testZipNumber1);
            zipList1.Add(testZipNumber2);

            zipList2.Add(list2ZipNumber1);
            zipList2.Add(list2ZipNumber2);

            actual = newZipList;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListZip_CheckThatDifferentSizeListZipCorrectly()
        {
            // Arrange
            CustomList<double> zipList1 = new CustomList<double>();
            double myNumber1 = 46;

            CustomList<double> zipList2 = new CustomList<double>();
            double theirNumber = 52;
            double theirNumber2 = 8;

            CustomList<double> newZipList = zipList1.Zip(zipList2);

            CustomList<double> actual;
            CustomList<double> expected = newZipList;

            // Act
            zipList1.Add(myNumber1);

            zipList2.Add(theirNumber);
            zipList2.Add(theirNumber2);

            actual = newZipList;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListZip_CheckThatStringListZipsCorrectly()
        {
            // Arrange
            CustomList<string> zipList1 = new CustomList<string>();
            string zipTestString1 = "I";
            string zipTestString2 = "How";
            string zipTestString3 = "Do";

            CustomList<string> zipList2 = new CustomList<string>();
            string list2TestString1 = "Know";
            string list2TestString2 = "To";
            string list2TestString3 = "This";

            CustomList<string> newZipList = zipList1.Zip(zipList2);

            CustomList<string> actual;
            CustomList<string> expected = newZipList;

            // Act
            zipList1.Add(zipTestString1);
            zipList1.Add(zipTestString2);
            zipList1.Add(zipTestString3);

            zipList2.Add(list2TestString1);
            zipList2.Add(list2TestString2);
            zipList2.Add(list2TestString3);


            actual = newZipList;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListZip_CheckThatMultipleListZipTogether()
        {
            // Arrange
            CustomList<int> zipList1 = new CustomList<int>();
            int testZipNumber1 = 2;
            int testZipNumber2 = 8;

            CustomList<int> zipList2 = new CustomList<int>();
            int list2ZipNumber1 = 4;
            int list2ZipNumber2 = 6;

            CustomList<int> zipList3 = new CustomList<int>();
            int list3ZipNumber1 = 1;
            int list3ZipNumber2 = 3;

            CustomList<int> newZipList = zipList3.Zip(zipList2, zipList1);

            CustomList<int> actual;
            CustomList<int> expected = newZipList;

            // Act
            zipList1.Add(testZipNumber1);
            zipList1.Add(testZipNumber2);

            zipList2.Add(list2ZipNumber1);
            zipList2.Add(list2ZipNumber2);

            zipList3.Add(list3ZipNumber1);
            zipList3.Add(list3ZipNumber2);

            actual = newZipList;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
