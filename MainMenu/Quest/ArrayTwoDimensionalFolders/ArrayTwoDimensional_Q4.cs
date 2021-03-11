using System;

namespace MainMenu.Quest.ArrayTwoDimensionalFolders
{
    public static class ArrayTwoDimensional_Q4
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
            //int y = 0;
            //int z = 0;
            //do
            //{
            //    for (int i = 0; i < ints[x].Length; i++)
            //    {
            //        if (ints[x][i] > tmp)
            //        {
            //            tmp = ints[x][i];
            //            y = x;
            //            z = i;
            //            i = 0;
            //        }
            //    }
            //    x++;
            //}
            //while (x < a);
            //Console.WriteLine($"\nМаксимальный элемент массива = {tmp} и его индекс = [{y}],[{z}]");
        }
    }
}