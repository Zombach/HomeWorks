using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MainMenu.Quest
{
    public static class Cycles
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
                case 11:
                    tmp = Quest_11(programClass);
                    break;
                case 12:
                    tmp = Quest_12(programClass);
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
            //Double result = 1;

            //Console.Write("Введите число A = ");
            //Double a = ConsoleInPut.InPutDouble();
            //Console.Write("Введите число B = ");
            //Double b = ConsoleInPut.InPutDouble();

            //for (int i = 0; i < b; i++)
            //{
            //    result *= a;
            //}
            //for (int i = 0; i > b; i--)
            //{
            //    result /= a;
            //}
            //Console.WriteLine($"Число A в степени В = {result}");
            //Console.WriteLine();
        }
        private static double[] Quest_2(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Console.Write("Введите число A = ");
            //int a = ConsoleInPut.InPutInt();
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % a == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.WriteLine("\n");
        }
        private static double[] Quest_3(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //int count = 0;

            //Console.Write("Введите число A = ");
            //int a = ConsoleInPut.InPutInt();

            //for (int i = 1; i <= a; i++)
            //{
            //    if (a > i * i)
            //    {
            //        count++;
            //    }
            //    else break;
            //}
            //Console.WriteLine(count);
            //Console.WriteLine();
        }
        private static double[] Quest_4(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //int result = 0;

            //Console.Write("Введите число A = ");
            //int a = ConsoleInPut.InPutInt();

            //for (int i = a - 1; i > 0; i--)
            //{
            //    if (a % i == 0)
            //    {
            //        result = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(result);
            //Console.WriteLine();
        }
        private static double[] Quest_5(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //int tmp;
            //int result = 0;

            //Console.Write("Введите число A = ");
            //int a = ConsoleInPut.InPutInt();
            //Console.Write("Введите число B = ");
            //int b = ConsoleInPut.InPutInt();

            //if (a > b)
            //{
            //    tmp = a;
            //    a = b;
            //    b = tmp;
            //}

            //for (int i = a + 1; i < b; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        result += i;
            //    }
            //}
            //Console.WriteLine(result);
            //Console.WriteLine();
        }
        private static double[] Quest_6(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //int n1 = 1;
            //int n2 = 1;
            //int sum = 0;

            //Console.Write("Введите число N = ");
            //int n = ConsoleInPut.InPutInt();

            //if (n == 1 || n == 2)
            //{
            //    Console.WriteLine("1");
            //}

            //for (int i = 2; i < n; i++)
            //{
            //    sum = n1 + n2;
            //    n1 = n2;
            //    n2 = sum;
            //}
            //Console.WriteLine(sum + "\n");
        }
        private static double[] Quest_7(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Console.Write("Введите число A = ");
            //int a = ConsoleInPut.InPutInt();
            //Console.Write("Введите число B = ");
            //int b = ConsoleInPut.InPutInt();
            //do
            //{
            //    if (a > b && a != 0 && b != 0)
            //    {
            //        a %= b;
            //    }
            //    else if (a < b && a != 0 && b != 0)
            //    {
            //        b %= a;
            //    }
            //    else
            //    {
            //        b = 0;
            //        break;
            //    }
            //}
            //while (a != 0 && b != 0);
            //Console.Write($"Наибольший общий делитель = {a + b}");
            //Console.WriteLine("\n");
        }
        private static double[] Quest_8(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Double x;
            //Double n;
            //int w;
            //do
            //{
            //    Console.Write("Введите целое число, у которого есть целый кубический корень: ");
            //    x = Convert.ToDouble(Console.ReadLine());
            //    n = Math.Round(Math.Pow(x, 1 / 3d));
            //    w = (int)n;
            //    if (Math.Pow(n, 3) == x && w == n)
            //    {
            //        break;
            //    }
            //}
            //while (true);

            //Double tmp = x;
            //Double tmp2 = 1;
            //Double temp = 0;

            //for (int i = 0; i < x; i--)
            //{
            //    temp = tmp;
            //    tmp = (tmp + tmp2) / 2;
            //    if (tmp > n)
            //    {
            //        continue;
            //    }
            //    else if (tmp < n)
            //    {
            //        tmp2 = tmp;
            //        tmp = temp;

            //    }
            //    else
            //    {
            //        Console.WriteLine(tmp);
            //        break;
            //    }
            //}
            //Console.WriteLine();
        }
        private static double[] Quest_9(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //string str;
            //int count = 0;
            //Console.Write("Введите число = ");
            //str = Console.ReadLine();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] % 2 != 0)
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //Console.WriteLine("Колличество нечетных цифр = " + count);
            //Console.WriteLine();
        }
        private static double[] Quest_10(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //string str;
            //int x;
            //Console.Write("Введите строку = ");
            //str = Console.ReadLine();
            //Console.Write("Использовать только цифры? Введите 1 если да, и 0 если нет = ");
            //do
            //{
            //    x = Convert.ToInt32(Console.ReadLine());
            //    if (x == 0 || x == 1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Нужно указать '1' либо '0' = ");
            //    Console.Write("Использовать только цифры? Введите 1 если да, и 0 если нет = ");
            //}
            //while (true);

            //string tmp = "";
            //if (x == 1)
            //{
            //    if (str[0] == Convert.ToChar("-"))
            //    {
            //        tmp = "-";
            //    }
            //    Regex regex = new Regex(@"\D");
            //    str = regex.Replace(str, "");
            //}

            //for (int i = 0; i < str.Length; i++)
            //{
            //    tmp += str[str.Length - 1 - i];
            //}
            //Console.WriteLine(tmp + "\n");
        }
        private static double[] Quest_11(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //string str;
            // Console.Write("Введите число N ");
            // str = Console.ReadLine();
            // Double temp = Convert.ToDouble(str);

            // for (int i = 1; i < temp; i++)
            // {
            //     Double sumX = 0;
            //     Double sumY = 0;
            //     string tmp = i.ToString();
            //     for (int j = 0; j < tmp.Length; j++)
            //     {
            //         int g = Convert.ToInt32(tmp[j]);
            //         if (g % 2 == 0)
            //         {
            //             sumX += g;
            //         }
            //         else
            //         {
            //             sumY += g;
            //         }
            //     }
            //     if (sumX > sumY)
            //     {
            //         Console.Write(tmp + " ");
            //     }
            // }
            // Console.WriteLine();
        }
        private static double[] Quest_12(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //string strX;
            //string strY;
            //Console.Write("Введите первую строку: ");
            //strX = Console.ReadLine();
            //Console.Write("Введите второе строку: ");
            //strY = Console.ReadLine();
            //int x;
            //Console.Write("Использовать для сравнения только цифры? Введите 1 если да, и 0 если нет = ");
            //do
            //{
            //    x = Convert.ToInt32(Console.ReadLine());
            //    if (x == 0 || x == 1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Нужно указать '1' либо '0' = ");
            //    Console.Write("Использовать для сравнения только цифры? Введите 1 если да, и 0 если нет = ");
            //}
            //while (true);

            //if (x == 1)
            //{
            //    Regex regex = new Regex(@"\D");
            //    strX = regex.Replace(strX, "");
            //    strY = regex.Replace(strY, "");
            //}

            //bool bo = false;
            //for (int i = 0; i < strX.Length; i++)
            //{
            //    for (int j = 0; j < strY.Length; j++)
            //    {
            //        if (strX[i] == strY[j])
            //        {
            //            bo = true;
            //            break;
            //        }
            //    }
            //}

            //if (bo)
            //{
            //    Console.WriteLine("ДА");
            //}
            //else
            //{
            //    Console.WriteLine("НЕТ");
            //}
            //Console.WriteLine();
        }
    }
}
