using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System;

namespace NumbersToWords.Tests
{
    [TestClass]
    public class NumbersTest : IDisposable

    {
        public void Dispose()
        {
            Numbers.output = "";
        }
        [TestMethod]
        public void CheckZero_ZeroToWord_Zero() 
        {
            Assert.AreEqual(true, Numbers.CheckZero(0));
        }

        [TestMethod]
        public void Convert_SingleDigitNumberToWord_WordForNumber()
        {
            Assert.AreEqual("three", Numbers.Convert(3));
        }

        [TestMethod]
        public void Convert_Teens_WordForNumber()
        {
            Assert.AreEqual("twelve", Numbers.Convert(12));
        }

        [TestMethod]
        public void Convert_MultiplesOfTen_WordForNumber()
        {
            Assert.AreEqual("thirty", Numbers.Convert(30));
        }

        [TestMethod]
        public void Convert_LessThan100_WordForNumber()
        {
            Assert.AreEqual("thirty three", Numbers.Convert(33));
        }
        [TestMethod]
        public void Convert_Multiples100_WordForNumber()
        {
            Assert.AreEqual("three hundred", Numbers.Convert(300));
        }
        [TestMethod]
        public void Convert_LessThan1000_WordForNumber()
        {
            Assert.AreEqual("three hundred forty five", Numbers.Convert(345));
        }
    }
}