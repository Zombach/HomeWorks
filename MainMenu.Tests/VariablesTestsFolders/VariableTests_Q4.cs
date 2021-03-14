using NUnit.Framework;
using MainMenu.Quest.VariablesFolders;
using System;

namespace MainMenu.Tests.VariablesTestsFolders
{
    class VariableTests_Q4
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Quest(int numberMock)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(numberMock);
            double[] actual = Variables_Q4.Quest(programClass);
            double[] expected = GetMockVariablesTests.GetExpectedMock_Q4(numberMock);
            DeltaFor.Delta(expected, actual);
        }
        [TestCase(6)]
        public void Devide_Exeption(int numberMock)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(numberMock);
            Assert.Throws<DivideByZeroException>(() => Variables_Q1.Quest(programClass));
        }
    }
}
