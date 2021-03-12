using NUnit.Framework;
using MainMenu.Quest.VariablesFolders;

namespace MainMenu.Tests.VariablesTestsFolders
{
    class VariableTests_Q2
    {
        [TestCase(1, new double[] { 2, 1 })]
        [TestCase(2, new double[] { 2, 2 })]
        public void Quest(int number, double[] expected)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(number);
            double[] actual = Variables_Q2.Quest(programClass);
            Assert.AreEqual(expected, actual);
        }
    }
}
