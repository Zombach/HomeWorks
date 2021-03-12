using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MainMenu
{
    public class ssss
    {

        public static int Test(int[] arrayX, int[] arrayY)
        {            
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
            return count;
        }
    }
}
