﻿using System;
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
            actual = customList.Count;
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
            actual = customList.Count;
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
            actual = customList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FivePositiveValues_FourIndexFive()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 5;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            actual = customList[4];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FivePositiveValues_ThirdIndexFour()
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 4;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            actual = customList[3];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OnePositiveVaules_CountTwo()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 2;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Remove(1);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_IndexZero_ValuesShiftDownIndex()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 2;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Remove(1);
            actual = customList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_AllIndexValues_CountZero()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 0;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Remove(1);
            customList.Remove(2);
            customList.Remove(3);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OnePositiveValue_ValueOneIndexZero()
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
            customList.Remove(2);
            actual = customList[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_SomethingNotInList()
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
            customList.Remove(500);
            actual = customList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_DuplicatedItem()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            
            int expected = 1;
            int actual;
            //act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value1);
            customList.Remove(1);
            actual = customList[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
