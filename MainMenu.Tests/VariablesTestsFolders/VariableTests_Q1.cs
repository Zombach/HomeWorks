﻿using NUnit.Framework;
using MainMenu.Quest.VariablesFolders;

namespace MainMenu.Tests.VariablesTestsFolders
{
    class VariableTests_Q1
    {
        [TestCase(1, new double[] { 9 })]
        [TestCase(4, new double[] { 31 })]
        public void Quest(int number, double[] expected)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(number);
            double[] actual = Variables_Q1.Quest(programClass);
            Assert.AreEqual(expected, actual);
        }
    }
}