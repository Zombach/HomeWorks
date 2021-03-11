using NUnit.Framework;
using MainMenu.Quest.VariablesFolders;

namespace MainMenu.Tests.VariablesTestsFolders
{
    class VariableTests_Q1
    {
        [TestCase(1, new double[] { 9 })]
        [TestCase(1, new double[] { 9 })]
        public void Quest(int number, double[] expected)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(number);
            double[] actual = new double[1];
            actual = Variables_Q1.Quest(programClass);
            Assert.AreEqual(expected, actual);
        }
    }
}
