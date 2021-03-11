using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingleTests_Q9
    {
        [TestCase(10, new double[] {0 })]
        [TestCase(19, new double[] { 3 })]
        [TestCase(18, new double[] { -1 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = new double[ints.Length];
            actual = ArraySingle_Q9.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
