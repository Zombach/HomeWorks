using NUnit.Framework;
using MainMenu.Quest.ArrayTwoDimensionalFolders;

namespace MainMenu.Tests.ArrayTwoDimensionalTestsFolders
{


    public class ArrayTwoDimensionalTests_Q6
    {
        [TestCase(10)]
        [TestCase(19)]
        [TestCase(18)]
        public void Quest(int number)
        {
            int[,] expected = new int[,]
            {
                { 1, 5, 548 },
                { 2, 61, 659 },
                { 4, 234, 3 }
            };
            int[,] ints = GetMockArrayTwoDimensionalTests.GetMock(number);
            int[,] actual = ArrayTwoDimensional_Q6.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
