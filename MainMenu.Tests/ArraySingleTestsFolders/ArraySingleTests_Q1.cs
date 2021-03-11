using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{


    public class ArraySingleTests_Q1
    {
        

        [TestCase( 1, new double[] { 0 })]
        [TestCase( 8, new double[] { 3 })]
        [TestCase( 15, new double[] { -11 })]
        public void Quest(int number, double[] expected)
        {
            int[] ints = GetMockArraySingleTests.GetMock(number);
            double[] actual = new double[1];
            actual = ArraySingle_Q1.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
