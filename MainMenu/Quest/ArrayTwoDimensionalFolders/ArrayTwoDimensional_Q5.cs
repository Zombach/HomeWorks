using System;

namespace MainMenu.Quest.ArrayTwoDimensionalFolders
{
    public static class ArrayTwoDimensional_Q5
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Random rnd = new Random();
            //int a = rnd.Next(2, 10);
            //int n;
            //int[][] ints = new int[a][];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    n = rnd.Next(2, 10);
            //    ints[i] = new int[n];
            //    Console.WriteLine();
            //    for (int j = 0; j < ints[i].Length; j++)
            //    {
            //        ints[i][j] = rnd.Next(1, 100);
            //        Console.Write(ints[i][j] + " ");
            //    }
            //}
            //int x = 0;
            //int tmp = ints[0][0];
            //int count = 0;
            //string str = "";
            //do
            //{
            //    for (int i = 0; i < ints[x].Length; i++)
            //    {
            //        if (x == 0 && i == 0)
            //        {
            //            //if ()
            //        }
            //        else if (x == 0 && i == ints[x].Length - 1)
            //        {

            //        }
            //        else if (x == ints.Length - 1 && i == 0)
            //        {
                    
            //        }
            //        else if (x == ints.Length - 1 && i == ints[x].Length - 1)
            //        {

            //        }
            //    }
            //    x++;
            //}
            //while (x < a);
            //Console.WriteLine($"\nКолличество элементов массива, которые больше всех своих соседей одновременно = {count}\n" +
            //    $"Значения этих элементов {str}");
        }
    }
}