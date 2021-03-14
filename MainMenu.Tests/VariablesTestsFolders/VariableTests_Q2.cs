using NUnit.Framework;
using MainMenu.Quest.VariablesFolders;

namespace MainMenu.Tests.VariablesTestsFolders
{
    class VariableTests_Q2
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Quest(int numberMock)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(numberMock);
            double[] actual = Variables_Q2.Quest(programClass);
            double[] expected = GetMockVariablesTests.GetExpectedMock_Q2(numberMock);
            Assert.AreEqual(expected, actual);
        }        
    }
}
