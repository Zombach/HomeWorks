using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
    class GetMockArraySingleTests
    {
        public static int[] GetMock(int number)
        {
            int[] result = new int[0];
            switch (number)
            {
                case 1:
                    result = new int[] { 1, 2, 4, 5, 61, 234, 548, 659, 3, 0 };
                    break;
                case 2:
                    result = new int[] { 8, 50, 4 };
                    break;
                case 3:
                    result = new int[] { 4, 22, 8, -3, 55 };
                    break;
                case 4:
                    result = new int[] { 1, 2, 4, 5, 61, 1, 6, 50, 3, 659, 3, 0 };
                    break;
                case 5:
                    result = new int[] { 8, 50, 3 };
                    break;
                case 6:
                    result = new int[] { 4, 20, 8, -1, 55, 50, 3 };
                    break;
                case 7:
                    result = new int[] { 1, 2, 50, 3, 1, 6, 16, 234, 3, 0 };
                    break;
                case 8:
                    result = new int[] { 8, 50, 3, 50, 3, 52, 3 };
                    break;
                case 9:
                    result = new int[] { 4, 20, 8, -1, 55 };
                    break;
                case 10:
                    result = new int[] { 1, 2, 4, 5, 61, 50, 3234, 548, 659, 3, 0 };
                    break;
                case 11:
                    result = new int[] { 8, 50, 4, 8, 9, 2 };
                    break;
                case 12:
                    result = new int[] { 4, 20, 8, 50, 355 };
                    break;
                case 13:
                    result = new int[] { 4, 20, 8, -1, 55 };
                    break;
                case 14:
                    result = new int[] { 1, 2, 50, 348, 659, 3, 0 };
                    break;
                case 15:
                    result = new int[] { 8, 50, 3, 9, -11, 4, 7 };
                    break;
                case 16:
                    result = new int[] { 4, 20, 8, -1, 55 };
                    break;
                case 17:
                    result = new int[] { 1, 2, 4, 5, 61, 1, 6, 1, 3, 0 };
                    break;
                case 18:
                    result = new int[] { 9, 8, 4, 8, 50, 3 };
                    break;
                case 19:
                    result = new int[] { 4, 20, -5, 50, 35 };
                    break;
                case 20:
                    result = new int[] { 1, 8, 50, 3, 50, 3, 548, 659, 3, 0 };
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
