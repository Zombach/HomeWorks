using NUnit.Framework;
using MainMenu.Quest;
using MainMenu.Text;
using System;
using MainMenu.Quest.ArraySingleFolders;

namespace MainMenu.Tests.ArraySingleTestsFolders
{


    public class ArraySingleTests_Q1
    {
        

        [TestCase( 1, new double[] { 24 })]
        [TestCase( 2, new double[] { 49 })]
        [TestCase( 1, new double[] { 89 })]
        public void Quest(int number, double[] expected)
        {
            double[] actual = new double[1];
            int[] ints = ArrayMock.GetMock(number);
            actual = ArraySingle_Q1.Quest(ints);
            Assert.AreEqual(expected, actual);
        }
    }
    
        public static class ArrayMock
    {
        public static int[] GetMock(int number)
        {
            int[] result = new int[0];
            switch (number)
            {
                case 1:
                    result = new int[] { 1, 2, 3 };
                    break;
                case 2:
                    result = new int[] { 1, 50, 3 };
                    break;
            }

            return result;
        }
    }
}
