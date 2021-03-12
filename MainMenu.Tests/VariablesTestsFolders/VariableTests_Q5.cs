using NUnit.Framework;
using MainMenu.Quest.VariablesFolders;

namespace MainMenu.Tests.VariablesTestsFolders
{
    class VariableTests_Q5
    {
        [TestCase(1, new double[] { 1, 2 })]
        [TestCase(3, new double[] { 1, 2 })]
        public void Quest(int number, double[] expected)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(number);
            double[] actual = Variables_Q5.Quest(programClass);
            Assert.AreEqual(expected, actual);
        }
    }
}
