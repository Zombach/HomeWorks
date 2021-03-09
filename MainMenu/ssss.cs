using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MainMenu
{
    public class ssss
    {

        public static void Test()
        {
            int[] arrayX = { 1, 2, 5, 8, 4, 7, 1, 1, 1 };
            int[] arrayY = { 1, 1, 9, 9, 4, 5 };
            
            int indexY = 0;
            int count = 0;
            for (int i = 0; i < arrayX.Length; i++)
            {
                if (indexY == arrayY.Length)
                {
                    break;
                }
                else if (indexY == arrayY.Length -1 && i == arrayX.Length - 1)
                {
                    if (arrayX[i] == arrayY[indexY])
                    {
                        count++;
                    }
                    indexY++;
                    i = -1;
                }
                else
                {
                    if (arrayX[i] == arrayY[indexY])
                    {
                        count++;
                    }
                }
                if (i == arrayX.Length - 1)
                {
                    indexY++;
                    i = -1;
                }
            }
            Console.WriteLine(count);

        }
    }
}
