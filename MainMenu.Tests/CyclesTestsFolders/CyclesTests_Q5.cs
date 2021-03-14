using MainMenu.Quest.CyclesFolder;
using NUnit.Framework;

namespace MainMenu.Tests.CyclesTestsFolders
{
    class CyclesTests_Q5
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Quest(int numberMock)
        {
            ProgramClass programClass = GetMockCyclesTests.GetMock(numberMock);
            double[] actual = Cycles_Q5.Quest(programClass);
            double[] expected = GetMockCyclesTests.GetExpectedMock_Q5(numberMock);
            Assert.AreEqual(expected, actual);
        }
    }
}
