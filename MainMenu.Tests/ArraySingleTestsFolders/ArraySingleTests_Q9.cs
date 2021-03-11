using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingleTests_Q9
    {
        [TestCase(10, new double[] { 0, 1, 2, 3, 4, 5, 50, 61, 548, 659, 3234 })]
        [TestCase(19, new double[] { -5, 4, 20, 35, 50 })]
        [TestCase(18, new double[] { 3, 4, 8, 8, 9, 50 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = new double[ints.Length];
            actual = ArraySingle_Q9.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
