using NUnit.Framework;
using MainMenu.Quest.VariablesFolders;
using System;

namespace MainMenu.Tests.VariablesTestsFolders
{
    class VariableTests_Q1
    {
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Quest(int numberMock)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(numberMock);
            double[] actual = Variables_Q1.Quest(programClass);
            double[] expected = GetMockVariablesTests.GetExpectedMock_Q1(numberMock);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2)]
        public void Devide_Exeption(int numberMock)
        {
            ProgramClass programClass = GetMockVariablesTests.GetMock(numberMock);
            Assert.Throws<DivideByZeroException>(() => Variables_Q1.Quest(programClass));
        }
    }
}
