using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Class_Project;
namespace CustomListUnitTesting
{
    [TestClass]
    public class AddTesting
    {
        [TestMethod]
        public void Add_AddOneValues_CountOf1()
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int expected = 0;
            int actual = customList.Count;
            customList.Add(value1);
            Assert.AreEqual(expected, actual);
        } 
        [TestMethod]
        public void Add_AddTwoValues_CountOf2()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddFiveValues_CheckCount()
        {
            CustomList<int> customList = new CustomList<int>();
            int expected = 5;
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            int actual = customList.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddTwoValues_CapacityOf4()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 4;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddFiveValues_CheckCapacity()
        {
            CustomList<int> customList = new CustomList<int>();
            int expected = 5;
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            int actual = customList.Capacity;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddThreeValues_CheckListOrder()
        {
            CustomList<int> customList = new CustomList<int>();
            //int value = new value? 
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            //make like and check the order of the list 
            int actual = customList[0];
            Assert.AreEqual(3, actual);
        }
        [TestMethod]
        public void Add_AddFiveValues_CheckListOrder()
        {
            CustomList<int> customList = new CustomList<int>();
            //int value = new value? 
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            //make like and check the order of the list 
            int actual = customList[0];
            Assert.AreEqual(5, actual);
        }
    }
}
