﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTest;
namespace NumbersUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void It_Should_Return_True()
        {
            Program objTest = new Program();
            Assert.IsTrue(objTest.printDigits(10, 100));
        }
        [TestMethod]
        public void It_Should_Return_Prime_True()
        {
            Program objTest = new Program();
            Assert.IsTrue(objTest.printDigitsWithPrimeAsText(10, 100));
        }
        [TestMethod]
        public void It_Should_Return_Composite_True()
        {
            Program objTest = new Program();
            Assert.IsTrue(objTest.printDigitsWithCompositeAsText(10, 100));
        }



    }
}
