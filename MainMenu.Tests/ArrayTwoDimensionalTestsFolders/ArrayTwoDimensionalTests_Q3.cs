using NUnit.Framework;
using MainMenu.Quest.ArrayTwoDimensionalFolders;

namespace MainMenu.Tests.ArrayTwoDimensionalTestsFolders
{
    public class ArrayTwoDimensionalTests_Q3
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        public void Quest(int numberMock)
        {
            int[,] tmp = GetMockArrayTwoDimensionalTests.GetMock(numberMock);
            double[] actual = ArrayTwoDimensional_Q3.Quest(tmp);
            double[] expected = GetMockArrayTwoDimensionalTests.GetExpectedMock_Q3(numberMock);
            Assert.AreEqual(expected, actual);
        }
    }
}
