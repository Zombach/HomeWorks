using NUnit.Framework;
using MainMenu.Quest.ArrayTwoDimensionalFolders;

namespace MainMenu.Tests.ArrayTwoDimensionalTestsFolders
{


    public class ArrayTwoDimensionalTests_Q6
    {
        [TestCase(10, new double[] { 1, 1, 2, 3, 4, 5, 50, 61, 548, 659, 3234 })]
        [TestCase(19, new double[] { -5, 4, 20, 35, 50 })]
        [TestCase(18, new double[]  { 1, 2, 4, 5, 61, 234, 548, 659, 3, 3 })]
        public void Quest(int number, double[] expected)
        {
            int[,] ints = GetMockArrayTwoDimensionalTests.GetMock(number);
            double[] actual = ArrayTwoDimensional_Q6.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
