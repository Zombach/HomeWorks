using NUnit.Framework;
using MainMenu.Quest.BranchingFolders;
using MainMenu.Tests.VariablesTestsFolders;

namespace MainMenu.Tests.BranchingTestsFolders
{
    class BranchingTests_Q4
    {
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        public void Quest(int numberMock)
        {
            ProgramClass programClass = GetMockBranchingTests.GetMock(numberMock);
            double[] actual = Branching_Q4.Quest(programClass);
            double[] expected = GetMockBranchingTests.GetExpectedMock_Q4(numberMock);
            DeltaFor.Delta(expected, actual);
        }
    }
}
