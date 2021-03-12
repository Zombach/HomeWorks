using NUnit.Framework;
using MainMenu.Quest.ArrayTwoDimensionalFolders;

namespace MainMenu.Tests.ArrayTwoDimensionalTestsFolders
{


    public class ArrayTwoDimensionalTests_Q6
    {
        [TestCase(20)]
        public void Quest(int number)
        {
            int[,] expected = null;
            switch (number)
            {
                case 18:
                    expected = new int[,]
                    {
                        { 1, 5, 548 },
                        { 2, 61, 659 },
                        { 4, 234, 3 }
                    };
                    break;
                case 20:
                    expected = new int[,]
                    {
                        { -11, -16, -21, -26, -31, -36 },
                        { -17, -22, -27, -32, -37, -42 },
                        { 23, 28, 33, 38, 43, 48 },
                        { 29, 34, 39, 44, 49, 54 },
                        { 35, 40, 45, 50, 55, 60 }
                    };
                    break;
            }

            
            int[,] ints = GetMockArrayTwoDimensionalTests.GetMock(number);
            int[,] actual = ArrayTwoDimensional_Q6.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
