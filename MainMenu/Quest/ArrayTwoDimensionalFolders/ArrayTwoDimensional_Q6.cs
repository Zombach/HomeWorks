using System;

namespace MainMenu.Quest.ArrayTwoDimensionalFolders
{
    public static class ArrayTwoDimensional_Q6
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
            //Console.WriteLine();
            //int x = 0;
            //int tmp = 0;
            //int tmpY = 0;

            //bool bo = false;
            //do
            //{
            //    for (int i = 0; i < ints[x].Length - 1; i++)
            //    {
            //        if (x == i)
            //        {
            //            bo = true;
            //            do
            //            {
            //                tmp = ints[x][i];
            //                try
            //                {
            //                    ints[x][i] = ints[ints.Length - 1 - x - tmpY][ints.Length - 1 - x - tmpY];
            //                    ints[ints.Length - 1 - x - tmpY][ints.Length - 1 - x - tmpY] = tmp;
            //                    bo = false;
            //                }
            //                catch
            //                {
            //                    tmpY++;
            //                }
            //            }
            //            while (bo);
            //        }
            //    }
            //    x++;
            //}
            //while (x < a/2);



            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < ints[i].Length; j++)
            //    {
            //        Console.Write(ints[i][j] + " ");
            //    }
            //}
            //Console.WriteLine();
        }
    }
}