using MainMenu.Quest.CyclesFolder;
using NUnit.Framework;

namespace MainMenu.Tests.CyclesTestsFolders
{
    class CyclesTests_Q10
    {
        [TestCase(1)]
        //[TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Quest(int numberMock)
        {
            ProgramClass programClass = GetMockCyclesTests.GetMock(numberMock);
            double[] actual = Cycles_Q10.Quest(programClass);
            double[] expected = GetMockCyclesTests.GetExpectedMock_Q10(numberMock);
            Assert.AreEqual(expected, actual);
        }
    }
}
