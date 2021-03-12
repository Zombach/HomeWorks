using NUnit.Framework;
using MainMenu.Quest.BranchingFolders;

namespace MainMenu.Tests.BranchingTestsFolders
{
    class BranchingTests_Q1
    {
        [TestCase(1, new double[] { -1 })]
        [TestCase(4, new double[] { -1 })]
        public void Quest(int number, double[] expected)
        {
            ProgramClass programClass = GetMockBranchingTests.GetMock(number);
            double[] actual = Branching_Q1.Quest(programClass);
            Assert.AreEqual(expected, actual);
        }
    }
}
