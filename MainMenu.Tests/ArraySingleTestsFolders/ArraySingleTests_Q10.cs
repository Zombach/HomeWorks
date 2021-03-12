using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingleTests_Q10
    {
        [TestCase(9, new double[] { 55, 20, 8, 4, -1 })]
        [TestCase(14, new double[] { 659, 348, 50, 3, 2, 1, 0})]
        [TestCase(20, new double[] { 659, 548, 50, 50, 8, 3, 3, 3, 1, 0 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = ArraySingle_Q10.Quest(ints);
            Assert.AreEqual(expected, actual);
        }        
    }

}
