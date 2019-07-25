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
            Numbers.input = 0;
            Assert.AreEqual(true, Numbers.CheckZero(Numbers.input));
        }

        [TestMethod]
        public void Convert_SingleDigitNumberToWord_WordForNumber()
        {
            Numbers.input = 3;
            Assert.AreEqual("three", Numbers.Convert(Numbers.input));
        }

        [TestMethod]
        public void Convert_Teens_WordForNumber()
        {
            Numbers.input = 12;
            Assert.AreEqual("twelve", Numbers.Convert(Numbers.input));
        }

        [TestMethod]
        public void Convert_MultiplesOfTen_WordForNumber()
        {
            Numbers.input = 30;
            Assert.AreEqual("thirty", Numbers.Convert(Numbers.input));
        }

        [TestMethod]
        public void Convert_LessThan100_WordForNumber()
        {
            Numbers.input = 33;
            Assert.AreEqual("thirty three", Numbers.Convert(Numbers.input));
        }
        [TestMethod]
        public void Convert_Multiples100_WordForNumber()
        {
            Numbers.input = 300;
            Assert.AreEqual("three hundred", Numbers.Convert(Numbers.input));
        }
        [TestMethod]
        public void Convert_LessThan1000_WordForNumber()
        {
            Numbers.input = 345;
            Assert.AreEqual("three hundred forty five", Numbers.Convert(Numbers.input));
        }
        [TestMethod]
        public void Convert_MultiplesOf1000_WordForNumber()
        {
            Numbers.input = 3000;
            Assert.AreEqual("three thousand", Numbers.Convert(Numbers.input));
        }
        [TestMethod]
        public void Convert_LessThan10000_WordForNumber()
        {
            Numbers.input = 3050;
            Assert.AreEqual("three thousand fifty", Numbers.Convert(Numbers.input));

        }
        [TestMethod]
        public void Convert_MultiplesOf10000_WordForNumber()
        {
            Numbers.input = 20000;
            Assert.AreEqual("twenty thousand", Numbers.Convert (Numbers.input));

        }

        // [TestMethod]
        // public void Convert_MultiplesOfMillion_WordForNumber()
        // {
        //     Assert.AreEqual("one million", Numbers.Convert(1000000));
        // }

        // [TestMethod]
        // public void Convert_LessThanMillion_WordForNumber()
        // {
        //     Assert.AreEqual("two hundred thousand", Numbers.Convert(200000));
        // }

        // // [TestMethod]
        // // public void Convert_LessThanMillion_WordForNumber()
        // {
        //     Assert.AreEqual("two hundred forty five thousand six hundred seventy eight", Numbers.Convert(245678));
        // }


    }
}