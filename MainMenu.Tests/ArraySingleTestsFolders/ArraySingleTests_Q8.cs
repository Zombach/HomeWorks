using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingleTests_Q8
    {
        [TestCase(8, new double[] { 3, 52, 3, 0, 8, 50, 3 })]
        [TestCase(2, new double[] { 4, 0, 8 })]
        [TestCase(13, new double[] { -1, 55, 0, 4, 20 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = new double[ints.Length];
            actual = ArraySingle_Q8.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
