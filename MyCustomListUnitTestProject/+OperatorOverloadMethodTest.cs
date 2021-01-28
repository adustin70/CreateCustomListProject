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
            int actual;
            int expected = 234815766;

            // Act
            list.Add(listFirstNum);
            list.Add(listSecondNum);
            list.Add(listThirdNum);

            list2.Add(list2FirstNum);
            list2.Add(list2SecondNum);
            list2.Add(list2ThirdNum);

            actual = list + list2;

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
            int actual;
            int expected = -23-4-81-5-76-6;

            // Act
            list.Add(listFirstNum);
            list.Add(listSecondNum);
            list.Add(listThirdNum);

            list2.Add(list2FirstNum);
            list2.Add(list2SecondNum);
            list2.Add(list2ThirdNum);

            actual = list + list2;

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
            double actual;
            double expected = 7894456;

            // Act
            doubleList.Add(doubleListNum);
            doubleList2.Add(doubleList2Num);

            actual = doubleList + doubleList2;

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
            double actual;
            double expected = -79 - 435 - 13 - 2;

            // Act
            list.Add(listNegativeNum);
            list.Add(listNegativeNum2);

            list2.Add(list2NegativeNum);
            list2.Add(list2NegativeNum2);

            actual = list + list2;

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
            string actual;
            string expected = "IHaveDevelopedAPassionForCoding";

            // Act
            stringList1.Add(testString1);
            stringList1.Add(testString2);
            stringList1.Add(testString3);

            stringList2.Add(list2TestString1);
            stringList2.Add(list2TestString2);

            stringList3.Add(list3TestString1);
            stringList3.Add(list3TestString2);

            actual = stringList1 + stringList2 + stringList3;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
