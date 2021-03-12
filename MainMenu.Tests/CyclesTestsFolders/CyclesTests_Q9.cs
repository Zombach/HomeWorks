﻿using MainMenu.Quest.CyclesFolder;
using NUnit.Framework;

namespace MainMenu.Tests.CyclesTestsFolders
{
    class CyclesTests_Q9
    {
        [TestCase(1, new double[] { 9 })]
        [TestCase(4, new double[] { 31 })]
        public void Quest(int number, double[] expected)
        {
            ProgramClass programClass = GetMockCyclesTests.GetMock(number);
            double[] actual = Cycles_Q9.Quest(programClass);
            Assert.AreEqual(expected, actual);
        }
    }
}
