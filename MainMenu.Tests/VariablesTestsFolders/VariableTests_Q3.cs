using NUnit.Framework;
using MainMenu.Quest.VariablesFolders;

namespace MainMenu.Tests.VariablesTestsFolders
{
    class VariableTests_Q3
    {
        [TestCase(1, new double[] { 0, 1 })]
        [TestCase(2, new double[] { 1, 0 })]
        public void Quest(int number, double[] expected)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(number);
            double[] actual = Variables_Q3.Quest(programClass);
            Assert.AreEqual(expected, actual);
        }
    }
}
