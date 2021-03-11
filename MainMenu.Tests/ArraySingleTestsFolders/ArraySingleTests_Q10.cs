using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingleTests_Q10
    {
        [TestCase(9, new double[] { 0 })]
        [TestCase(14, new double[] { 3 })]
        [TestCase(20, new double[] { -1 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = new double[ints.Length];
            actual = ArraySingle_Q10.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
