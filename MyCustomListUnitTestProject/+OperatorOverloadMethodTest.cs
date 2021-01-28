using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCustomList;

namespace MyCustomListUnitTestProject
{
    [TestClass]
    public class _OperatorOverloadMethodTest
    {
        [TestMethod]
        public void CustomListPlusOverload_CheckThatListOfIntsAddTogether()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int listFirstNum = 23;
            int listSecondNum = 4;
            int listThirdNum = 81;

            CustomList<int> list2 = new CustomList<int>();
            int list2FirstNum = 5;
            int list2SecondNum = 76;
            int list2ThirdNum = 6;
            CustomList<int> actual;
            CustomList<int> expected = list2 + list;

            // Act
            list.Add(listFirstNum);
            list.Add(listSecondNum);
            list.Add(listThirdNum);

            list2.Add(list2FirstNum);
            list2.Add(list2SecondNum);
            list2.Add(list2ThirdNum);

            actual = list2 + list;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListPlusOverload_CheckThatListOfNegativeIntsAddTogether()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int listFirstNum = -23;
            int listSecondNum = -4;
            int listThirdNum = -81;

            CustomList<int> list2 = new CustomList<int>();
            int list2FirstNum = -5;
            int list2SecondNum = -76;
            int list2ThirdNum = -6;
            CustomList<int> actual;
            CustomList<int> expected = list2 + list;

            // Act
            list.Add(listFirstNum);
            list.Add(listSecondNum);
            list.Add(listThirdNum);

            list2.Add(list2FirstNum);
            list2.Add(list2SecondNum);
            list2.Add(list2ThirdNum);

            actual = list2 + list;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListPlusOverload_CheckThatListOfDoublesAddTogether()
        {
            // Arrange
            CustomList<double> doubleList = new CustomList<double>();
            double doubleListNum = 789;

            CustomList<double> doubleList2 = new CustomList<double>();
            double doubleList2Num = 456;
            CustomList<double> actual;
            CustomList<double> expected = doubleList2 + doubleList;

            // Act
            doubleList.Add(doubleListNum);
            doubleList2.Add(doubleList2Num);

            actual = doubleList2 + doubleList;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListPlusOverload_CheckThatListOfDecimalsAddTogether()
        {
            // Arrange
            CustomList<double> list = new CustomList<double>();
            double listNegativeNum = -79;
            double listNegativeNum2 = -435;

            CustomList<double> list2 = new CustomList<double>();
            double list2NegativeNum = -13;
            double list2NegativeNum2 = -2;
            CustomList<double> actual;
            CustomList<double> expected = list2 + list;

            // Act
            list.Add(listNegativeNum);
            list.Add(listNegativeNum2);

            list2.Add(list2NegativeNum);
            list2.Add(list2NegativeNum2);

            actual = list2 + list;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomListPlusOverload_AddThreeList_CheckThatTheListAddTogether()
        {
            // Arrange
            CustomList<string> stringList1 = new CustomList<string>();
            string testString1 = "I";
            string testString2 = "Have";
            string testString3 = "Developed";

            CustomList<string> stringList2 = new CustomList<string>();
            string list2TestString1 = "A";
            string list2TestString2 = "Passion";

            CustomList<string> stringList3 = new CustomList<string>();
            string list3TestString1 = "For";
            string list3TestString2 = "Coding";
            CustomList<string> actual;
            CustomList<string> expected = stringList1 + stringList2 + stringList3;

            // Act
            stringList1.Add(testString1);
            stringList1.Add(testString2);
            stringList1.Add(testString3);

            stringList2.Add(list2TestString1);
            stringList2.Add(list2TestString2);

            stringList3.Add(list3TestString1);
            stringList3.Add(list3TestString2);

            actual = stringList1 + stringList2 + stringList3;
            // Yoda says ^^
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
