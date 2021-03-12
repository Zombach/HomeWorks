using NUnit.Framework;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
    public class ArraySingleTests_Q6
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Quest(int numberMock)
        {
            int[] ints = GetMockArraySingleTests.GetMock(numberMock);
            double[] actual = ArraySingle_Q6.Quest(ints);
            double[] expected = GetMockArraySingleTests.GetExpectedMock_Q6(numberMock);
            Assert.AreEqual(expected, actual);
        }
    }
}
