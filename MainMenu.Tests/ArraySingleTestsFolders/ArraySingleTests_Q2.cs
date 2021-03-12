using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{


    public class ArraySingleTests_Q2
    {
        [TestCase(1, new double[] { 659 })]
        [TestCase(12, new double[] { 355 })]
        [TestCase(13, new double[] { 55 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = ArraySingle_Q2.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }    
}