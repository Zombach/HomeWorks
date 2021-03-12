using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingleTests_Q3
    {
        [TestCase(7, new double[] { 9 })]
        [TestCase(8, new double[] { 2 })]
        [TestCase(3, new double[] { 3 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = ArraySingle_Q3.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
