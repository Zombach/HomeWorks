using NUnit.Framework;
using MainMenu.Quest.VariablesFolders;

namespace MainMenu.Tests.VariablesTestsFolders
{
    class VariableTests_Q4
    {
        [TestCase(1, new double[] { 1 })]
        [TestCase(2, new double[] { 0 })]
        [TestCase(3, new double[] { 1 })]
        [TestCase(4, new double[] { 0 })]
        [TestCase(5, new double[] { -19 })]
        public void Quest(int number, double[] expected)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(number);
            double[] actual = Variables_Q4.Quest(programClass);
            DeltaForVariable.DeltaVariables(expected, actual);            
        }
    }
}
