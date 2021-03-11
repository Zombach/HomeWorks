﻿using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingleTests_Q5
    {
        [TestCase(15, new double[] { 63 })]
        [TestCase(4, new double[] { 717 })]
        [TestCase(3, new double[] { 19 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = new double[1];
            actual = ArraySingle_Q5.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}