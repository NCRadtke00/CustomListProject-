 using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Class_Project;

namespace CustomListUnitTesting
{
    [TestClass]
    public class OverloadRemoveUnitTesting
    {
        [TestMethod]
        public void OverloadRemove_TwoLists_CheckCount()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expectedResult = 0;

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList2.Add(3);
            customList2.Add(5);
            CustomList<int> removedList = customList - customList2;
            int actualResult = removedList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod12()
        {
        }
        [TestMethod]
        public void TestMethod13()
        {
        }
        [TestMethod]
        public void TestMethod14()
        {
        }
        [TestMethod]
        public void TestMethod15()
        {
        }
    }
}
