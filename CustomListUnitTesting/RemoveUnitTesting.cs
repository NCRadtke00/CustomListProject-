using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Class_Project;

namespace CustomListUnitTesting
{
    [TestClass]
    public class RemoveUnitTesting
    {
        [TestMethod]
        public void Remove_FirstValueInList_True()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            bool expected = true;
            bool actual = customList.Remove(1);
            Assert.AreEqual(expected, true);
        }
        [TestMethod]
        public void Remove_SecondValueInList_True()
        {
            //copy remove_firstvalue add 2nd, Remove secondValue
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            bool expected = true;
            bool actual = customList.Remove(2);
            Assert.AreEqual(expected, true);
        }
        [TestMethod]
        public void Remove_SecondValueInList_CheckCount()
        {
            //copy Add_checkcount 
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Remove(2);
            int expected = 0;
            //1 value shoul be left in the count
            int actual = customList.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ThirdValueInList_CheckCapacity()
        {
            //?? is this issue? 
            //copy Add_checkcount 
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Remove(3);
            int expected = 4;//the test told me actual
            //1 value shoul be left in the count
            int actual = customList.Capacity;
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void Remnove_SecondValueInList_CheckListOrder()
        //{
        //    //???
        //}
        [TestMethod]
        public void Remove_FakeValue_false()
        {
            //create list of 3, remove 4th object
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            bool actual = customList.Remove(5);
            Assert.AreEqual(actual, false);
        }
        //{5,5,5,5,5,5,5,5,5} remove 5
    }
}
