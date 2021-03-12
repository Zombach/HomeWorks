using NUnit.Framework;
using MainMenu.Quest.BranchingFolders;

namespace MainMenu.Tests.BranchingTestsFolders
{
    class BranchingTests_Q2
    {
        [TestCase(1, new double[] { 9 })]
        [TestCase(4, new double[] { 31 })]
        public void Quest(int number, double[] expected)
        {
            ProgramClass programClass = GetMockBranchingTests.GetMock(number);
            double[] actual = Branching_Q2.Quest(programClass);
            Assert.AreEqual(expected, actual);
        }
    }
}
