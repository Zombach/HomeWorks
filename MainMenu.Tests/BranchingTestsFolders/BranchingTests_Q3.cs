using NUnit.Framework;
using MainMenu.Quest.BranchingFolders;

namespace MainMenu.Tests.BranchingTestsFolders
{
    class BranchingTests_Q3
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Quest(int numberMock)
        {
            ProgramClass programClass = GetMockBranchingTests.GetMock(numberMock);
            double[] actual = Branching_Q3.Quest(programClass);
            double[] expected = GetMockBranchingTests.GetExpectedMock_Q3(numberMock);
            Assert.AreEqual(expected, actual);
        }
    }
}
