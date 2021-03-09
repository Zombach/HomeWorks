using System;
using System.Collections.Generic;
using System.Text;

namespace MainMenu.Quest
{
    public static class ArrayTwoDimensional
    {
        public static double[] QuestAll(ProgramClass programClass)
        {
            double[] tmp = null;
            switch (programClass.dataTextY)
            {
                case 1:
                    tmp = Quest_1(programClass);
                    break;
                case 2:
                    tmp = Quest_2(programClass);
                    break;
                case 3:
                    tmp = Quest_3(programClass);
                    break;
                case 4:
                    tmp = Quest_4(programClass);
                    break;
                case 5:
                    tmp = Quest_5(programClass);
                    break;
                case 6:
                    tmp = Quest_6(programClass);
                    break;
                default:
                    break;
            }
            return tmp;
        }

        private static double[] Quest_1(ProgramClass programClass)
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
            //        ints[i][j] = rnd.Next(0, 100);
            //        Console.Write(ints[i][j] + " ");
            //    }
            //}
            //int x = 0;
            //int tmp = ints[0][0];
            //do
            //{
            //    for (int i = 0; i < ints[x].Length; i++)
            //    {
            //        if (ints[x][i] < tmp)
            //        {
            //            tmp = ints[x][i];
            //            i = 0;
            //        }
            //    }
            //    x++;
            //}
            //while (x < a);
            //Console.WriteLine($"\nМинимальный элемент массива = {tmp}");
        }
        private static double[] Quest_2(ProgramClass programClass)
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
            //        ints[i][j] = rnd.Next(0, 100);
            //        Console.Write(ints[i][j] + " ");
            //    }
            //}
            //int x = 0;
            //int tmp = ints[0][0];
            //do
            //{
            //    for (int i = 0; i < ints[x].Length; i++)
            //    {
            //        if (ints[x][i] > tmp)
            //        {
            //            tmp = ints[x][i];
            //            i = 0;
            //        }
            //    }
            //    x++;
            //}
            //while (x < a);
            //Console.WriteLine($"\nМаксимальный элемент массива = {tmp}");
        }
        private static double[] Quest_3(ProgramClass programClass)
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
            //        ints[i][j] = rnd.Next(0, 100);
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
            //        if (ints[x][i] < tmp)
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
            //Console.WriteLine($"\nМинимальный элемент массива = {tmp} и его индекс = [{y}],[{z}]");
        }
        private static double[] Quest_4(ProgramClass programClass)
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
        private static double[] Quest_5(ProgramClass programClass)
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
        private static double[] Quest_6(ProgramClass programClass)
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