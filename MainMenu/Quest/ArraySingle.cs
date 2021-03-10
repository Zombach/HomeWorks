using System;
using System.Collections.Generic;
using System.Text;

namespace MainMenu.Quest
{
    public static class ArraySingle
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
                case 7:
                    tmp = Quest_7(programClass);
                    break;
                case 8:
                    tmp = Quest_8(programClass);
                    break;
                case 9:
                    tmp = Quest_9(programClass);
                    break;
                case 10:
                    tmp = Quest_10(programClass);
                    break;
                default:
                    break;
            }
            return tmp;
        }
        private static double[] Quest_1(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            int[] ints = new int[programClass.dataQueriesClass.number_1];
            for (int i = 1; i <= ints.Length; i++)
            {
                ints[i - 1] = i * programClass.dataQueriesClass.number_2 + programClass.dataQueriesClass.number_1;
                Console.WriteLine(ints[i-1]);
            }
            tmp[0] = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < tmp[0])
                {
                    tmp[0] = ints[i];
                    //Console.WriteLine(ints[i]);
                    //Console.WriteLine(tmp[0]);
                }
            }
            return tmp;
        }

        private static double[] Quest_2(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            int[] ints = new int[programClass.dataQueriesClass.number_1];
            for (int i = 1; i <= ints.Length; i++)
            {
                ints[i - 1] = i * programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1;
            }
            tmp[0] = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > tmp[0])
                {
                    tmp[0] = ints[i];
                }
            }
            return tmp;
        }

        private static double[] Quest_3(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp; 
            //Random rnd = new Random();
            //int a = rnd.Next(2, 20);
            //int[] ints = new int[a];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = rnd.Next(-99, 100);
            //    Console.Write(ints[i] + " ");
            //}
            //int tmp = ints[0];
            //int tmp2 = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] < tmp)
            //    {
            //        tmp = ints[i];
            //        tmp2 = i;
            //    }
            //}
            //Console.WriteLine("\n" + tmp2 + "\n");
        }

        private static double[] Quest_4(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Random rnd = new Random();
            //int a = rnd.Next(2, 20);
            //int[] ints = new int[a];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = rnd.Next(-99, 100);
            //    Console.Write(ints[i] + " ");
            //}
            //int tmp = ints[0];
            //int tmp2 = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] > tmp)
            //    {
            //        tmp = ints[i];
            //        tmp2 = i;
            //    }
            //}
            //Console.WriteLine("\n" + tmp2 + "\n");
        }

        private static double[] Quest_5(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Random rnd = new Random();
            //int a = rnd.Next(2, 20);
            //int[] ints = new int[a];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = rnd.Next(-99, 100);
            //    Console.Write(ints[i] + " ");
            //}
            //int count = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        count += ints[i];
            //    }
            //}
            //Console.WriteLine("\n" + count + "\n");
        }

        private static double[] Quest_6(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Random rnd = new Random();
            //int a = rnd.Next(2, 20);
            //int[] ints = new int[a];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = rnd.Next(-99, 100);
            //    Console.Write(ints[i] + " ");
            //}
            //Console.WriteLine();
            //int tmp = 0;
            //int tmp2 = ints.Length/2;
            //for (int i = 0; i < tmp2; i++)
            //{
            //    if (i < tmp2)
            //    {
            //        tmp = ints[i];
            //        ints[i] = ints[ints.Length - i - 1];
            //        ints[ints.Length - i - 1] = tmp;
            //    }
            //}
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.Write(ints[i] + " ");
            //}
            //Console.WriteLine();
        }

        private static double[] Quest_7(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Random rnd = new Random();
            //int a = rnd.Next(2, 20);
            //int[] ints = new int[a];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = rnd.Next(-99, 100);
            //    Console.Write(ints[i] + " ");
            //}
            //int count = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] % 2 != 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("\n" + count + "\n");
        }

        private static double[] Quest_8(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Random rnd = new Random();
            //int a = rnd.Next(2, 20);
            //int[] ints = new int[a];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = rnd.Next(-99, 100);
            //    Console.Write(ints[i] + " ");
            //}
            //Console.WriteLine();
            //int tmp = 0;
            //int tmp2 = (ints.Length -1) / 2;
            //for (int i = 0; i < tmp2; i++)
            //{
            //    tmp = ints[i];
            //    ints[i] = ints[tmp2 + i + 1];
            //    ints[tmp2 + i + 1] = tmp;
            //}
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.Write(ints[i] + " ");
            //}
            //Console.WriteLine();
        }

        private static double[] Quest_9(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Random rnd = new Random();
            //int a = rnd.Next(2, 20);
            //int[] ints = new int[a];
            //int[] ints2 = new int[ints.Length];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = rnd.Next(-99, 100);
            //    Console.Write(ints[i] + " ");
            //}
            //Console.WriteLine();
            //int tmp = 0;
            //for (int i = 0; i < ints.Length - 1; i++)
            //{
            //    tmp = ints[i];
            //    for (int j = 1 + i; j < ints.Length; j++)
            //    {
            //        if (ints[i] > ints[j])
            //        {
            //            tmp = ints[i];
            //            ints[i] = ints[j];
            //            ints[j] = tmp;
            //        }
            //        Console.Write("Проверка = " + ints[i]);
            //    }
            //}
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.Write(ints[i] + " ");
            //}
            //Console.WriteLine();
        }

        private static double[] Quest_10(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Random rnd = new Random();
            //int a = rnd.Next(2, 20);
            //int[] ints = new int[a];
            //int[] ints2 = new int[ints.Length];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = rnd.Next(-99, 100);
            //    Console.Write(ints[i] + " ");
            //}
            //Console.WriteLine();
            //int tmp = 0;
            //for (int i = 0; i < ints.Length - 1; i++)
            //{
            //    if (ints[i] < ints[i+1])
            //    {
            //        tmp = ints[i];
            //        ints[i] = ints[i + 1];
            //        ints[i + 1] = tmp;
            //        for (int j = i; j > 0; j--)
            //        {
            //            if (j < 0)
            //            {
            //                break;
            //            }
            //            else if (ints[j - 1] < ints[j] )
            //            {
            //                tmp = ints[j];
            //                ints[j] = ints[j - 1];
            //                ints[j - 1] = tmp;
            //            }
            //            else break;
            //        }
            //    }
            //}
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.Write(ints[i] + " ");
            //}
            //Console.WriteLine();
        }
    }
}
