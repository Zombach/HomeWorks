using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingleTests_Q4
    {
        [TestCase(9, new double[] { 4 })]
        [TestCase(1, new double[] { 7 })]
        [TestCase(7, new double[] { 7 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = ArraySingle_Q4.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
