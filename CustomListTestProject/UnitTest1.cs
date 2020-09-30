using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Runtime.Remoting;

namespace CustomListTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ThreePositiveValues_CountThree()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 3;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            actual = customList.count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_OneValue_CountOne()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int expected = 1;
            int actual;
            //act
            customList.Add(value1);
            actual = customList.count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ThreePositiveValues_ZeroIndexOne()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 1;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            actual = customList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ThreePositiveValues_SecondIndexThree()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 3;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            actual = customList[2];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FivePositibeValues_CapacityDoubles()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 8;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            actual = customList.capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
