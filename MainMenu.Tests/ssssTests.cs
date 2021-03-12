using NUnit.Framework;

namespace MainMenu.Tests
{
    public class ssssTests
    {
        [TestCase(new int[] { }, new int[] { }, 0)]
        [TestCase(new int[] { 1 }, new int[] { }, 0)]
        [TestCase(new int[] { }, new int[] { 1 }, 0)]
        [TestCase(new int[] { 1 }, new int[] { 2 }, 0)]
        [TestCase(new int[] { 1 }, new int[] { 1 }, 1)]
        [TestCase(new int[] { 1, 4 }, new int[] { 1, 4 }, 2)]
        [TestCase(new int[] { 3, 5 }, new int[] { 7, 9 }, 0)]
        [TestCase(new int[] { 2, 2 }, new int[] { 2, 2 }, 4)]
        [TestCase(new int[] { 5, 5, 5, 5, 5 }, new int[] { 5, 5, 5, 5, 5 }, 25)]
        [TestCase(new int[] { 6, 6, 6, 6, 6, 6 }, new int[] { 6, 6, 6, 6, 6, 6 }, 36)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 7, 8, 9, 10, 11, 12 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 1, 12 }, 5)]
        [TestCase(new int[] { 1, 1, 1, 4, 5, 6 }, new int[] { 1 }, 3)]
        [TestCase(new int[] { 2 }, new int[] { 1, 2, 3, 4, 2, 12 }, 2)]
        public void tests(int[] arrayX, int[] arrayY, int expected)
        {
            int actual = ssss.Test(arrayX, arrayY);
            Assert.AreEqual(expected, actual);
        }
    }
}