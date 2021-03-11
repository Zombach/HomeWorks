using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingleTests_Q6
    {
        [TestCase(16, new double[] { 55, -1, 8, 20, 4 })]
        [TestCase(20, new double[] { 0, 3, 659, 548, 3, 50, 3, 50, 8, 1})]
        [TestCase(3, new double[] { 55, -3, 8, 22, 4 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = new double[ints.Length];
            actual = ArraySingle_Q6.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
