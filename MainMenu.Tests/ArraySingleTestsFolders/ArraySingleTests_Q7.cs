using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingleTests_Q7
    {
        [TestCase(17, new double[] { 6 })]
        [TestCase(11, new double[] { 1 })]
        [TestCase(9, new double[] { 2 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = new double[1];
            actual = ArraySingle_Q7.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
