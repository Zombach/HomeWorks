using NUnit.Framework;
using MainMenu.Quest.BranchingFolders;
using System;

namespace MainMenu.Tests.BranchingTestsFolders
{
    class BranchingTests_Q5
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void Quest(int numberMock)
        {
            ProgramClass programClass = GetMockBranchingTests.GetMock(numberMock);
            double[] actual = Branching_Q5.Quest(programClass);
            double[] expected = GetMockBranchingTests.GetExpectedMock_Q5(numberMock);
            Assert.AreEqual(expected, actual);
        }
    }
}
