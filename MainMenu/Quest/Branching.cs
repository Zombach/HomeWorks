using System;
using System.Collections.Generic;
using System.Text;

namespace MainMenu.Quest
{
    public static class Branching
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
                default:
                    break;
            }
            return tmp;
        }
        private static double[] Quest_1(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            if (programClass.dataQueriesClass.number_1 > programClass.dataQueriesClass.number_2)
            {
                tmp[0] = programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2;
            }
            else if (programClass.dataQueriesClass.number_1 == programClass.dataQueriesClass.number_2)
            {
                programClass.dataTextClass.answerString++;
                tmp[0] = programClass.dataQueriesClass.number_1 * programClass.dataQueriesClass.number_2;
            }
            else if (programClass.dataQueriesClass.number_1 < programClass.dataQueriesClass.number_2)
            {
                programClass.dataTextClass.answerString++;
                programClass.dataTextClass.answerString++;
                tmp[0] = programClass.dataQueriesClass.number_1 - programClass.dataQueriesClass.number_2;
            }
            return tmp;            
        }
        private static double[] Quest_2(ProgramClass programClass)
        {
            programClass.dataTextClass.answerString = 4;
            double[] tmp = new double[1];
            if (programClass.dataQueriesClass.number_1 > 0)
            {
                if (programClass.dataQueriesClass.number_2 > 0)
                {
                    tmp[0] = 1;
                }
                else
                {
                    tmp[0] = 4;
                    programClass.dataTextClass.answerString += 3;
                }
            }
            else if (programClass.dataQueriesClass.number_1 < 0)
            {
                if (programClass.dataQueriesClass.number_2 > 0)
                {
                    tmp[0] = 2;
                    programClass.dataTextClass.answerString++;
                }
                else
                {
                    tmp[0] = 3;
                    programClass.dataTextClass.answerString += 2;
                }
            }
            else if (programClass.dataQueriesClass.number_1 == 0 ||
                programClass.dataQueriesClass.number_2 == 0)
            {
                tmp = null;
                programClass.dataTextClass.answerString += 4;
            }        
            return tmp;
        }
        private static double[] Quest_3(ProgramClass programClass)
        {
            programClass.dataTextClass.answerString = 9;
            double[] tmp = new double[3];
            if (programClass.dataQueriesClass.number_1 > programClass.dataQueriesClass.number_2)
            {
                tmp[0] = programClass.dataQueriesClass.number_1;
                programClass.dataQueriesClass.number_1 = programClass.dataQueriesClass.number_2;
                programClass.dataQueriesClass.number_2 = (int )tmp[0];
            }
            if (programClass.dataQueriesClass.number_1 > programClass.dataQueriesClass.number_3)
            {
                tmp[1] = programClass.dataQueriesClass.number_1;
                programClass.dataQueriesClass.number_1 = programClass.dataQueriesClass.number_3;
                programClass.dataQueriesClass.number_3 = (int)tmp[1];
            }
            if (programClass.dataQueriesClass.number_2 > programClass.dataQueriesClass.number_3)
            {
                tmp[2] = programClass.dataQueriesClass.number_2;
                programClass.dataQueriesClass.number_2 = programClass.dataQueriesClass.number_3;
                programClass.dataQueriesClass.number_3 = (int)tmp[2];
            }
            tmp[0] = programClass.dataQueriesClass.number_1;
            tmp[1] = programClass.dataQueriesClass.number_2;
            tmp[2] = programClass.dataQueriesClass.number_3;
            return tmp;
        }
        private static double[] Quest_4(ProgramClass programClass)
        {
            double[] tmp = new double[2];
            tmp[0] = programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2 + 4 * programClass.dataQueriesClass.number_1 * programClass.dataQueriesClass.number_3;

            if (tmp[0] > 0)
            {
                tmp[0] = (-programClass.dataQueriesClass.number_2 + Math.Sqrt(tmp[0])) / (2 * programClass.dataQueriesClass.number_1);
                tmp[1] = (-programClass.dataQueriesClass.number_2 - Math.Sqrt(tmp[0])) / (2 * programClass.dataQueriesClass.number_1);
            }
            else
            {
                tmp = null;
            }
            return tmp;
        }
        private static double[] Quest_5(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //int numX;
            //int numI;
            //string str = "";
            //Console.Write("Введите двухзначное число = ");
            //numX = Convert.ToInt32(Console.ReadLine());
            //if (numX < 10 || numX > 99) Console.WriteLine("Вы ввели не правильное число");
            //if (numX > 9 && numX < 19)
            //{
            //    numI = 10;
            //    int tmp = numX - numI;
            //    if (tmp == 0) str = "Десять";
            //    else if (tmp == 1) str = "Одинадцать";
            //    else if (tmp == 2) str = "Двенадцать";
            //    else if (tmp == 3) str = "Тринадцать";
            //    else if (tmp == 4) str = "Четырнадцать";
            //    else if (tmp == 5) str = "Петнадцать";
            //    else if (tmp == 6) str = "Шеснадцать";
            //    else if (tmp == 7) str = "Семнадцать";
            //    else if (tmp == 8) str = "Восемнадцать";
            //    else if (tmp == 9) str = "Девятнадцать";
            //    Console.WriteLine($"Введенное число: {str}");
            //}
            //else if (numX > 19 && numX < 29)
            //{
            //    numI = 20;
            //    str = "Двадцать ";
            //    Quest5_2(numX, numI, str);
            //}
            //else if (numX > 29 && numX < 39)
            //{
            //    numI = 30;
            //    str = "Тридцать ";
            //    Quest5_2(numX, numI, str);
            //}
            //else if (numX > 39 && numX < 49)
            //{
            //    numI = 40;
            //    str = "Сорок ";
            //    Quest5_2(numX, numI, str);
            //}
            //else if (numX > 49 && numX < 59)
            //{
            //    numI = 50;
            //    str = "Пятдесят ";
            //    Quest5_2(numX, numI, str);
            //}
            //else if (numX > 59 && numX < 69)
            //{
            //    numI = 60;
            //    str = "Шестьдесят ";
            //    Quest5_2(numX, numI, str);
            //}
            //else if (numX > 69 && numX < 79)
            //{
            //    numI = 70;
            //    str = "Семьдесят ";
            //    Quest5_2(numX, numI, str);
            //}
            //else if (numX > 79 && numX < 89)
            //{
            //    numI = 80;
            //    str = "Восемьдесят ";
            //    Quest5_2(numX, numI, str);
            //}
            //else if (numX > 89 && numX < 99)
            //{
            //    numI = 90;
            //    str = "Девяносто ";
            //    Quest5_2(numX, numI, str);
            //}
        }
        //static double[] Quest5_2(int numX, int numI, string str)
        //{
        //    double[] tmp = new double[1];
        //    tmp[0] = (5 * programClass.dataQueriesClass.Number_1 + programClass.dataQueriesClass.Number_2 * programClass.dataQueriesClass.Number_2) /
        //        (programClass.dataQueriesClass.Number_2 - programClass.dataQueriesClass.Number_1);
        //    return tmp;
        //    //int tmp = numX - numI;
        //    //if (tmp == 1) str += "один";
        //    //else if (tmp == 2) str += "два";
        //    //else if (tmp == 3) str += "три";
        //    //else if (tmp == 4) str += "четыре";
        //    //else if (tmp == 5) str += "пять";
        //    //else if (tmp == 6) str += "шесть";
        //    //else if (tmp == 7) str += "семь";
        //    //else if (tmp == 8) str += "восемь";
        //    //else if (tmp == 9) str += "девять";
        //    //Console.WriteLine($"Введенное число: {str}");
        //}
        private static double[] Quest_5V2(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //int inX;
            //int tens;
            //int remainder;
            //string str;
            //string exit;

            //while (true)
            //{
            //    Console.Write("Введите двухзначное число = ");
            //    inX = Convert.ToInt32(Console.ReadLine());
            //    tens = inX / 10;
            //    if (tens > 0 && tens < 10)
            //    {
            //        break;
            //    }
            //}
            //remainder = inX % 10;

            //switch (tens)
            //{
            //    case 1:
            //        switch (remainder)
            //        {
            //            case 0:
            //                exit = "Десять";
            //                break;
            //            case 1:
            //                exit = "Одиннадцать";
            //                break;
            //            case 2:
            //                exit = "Двенадцать";
            //                break;
            //            case 3:
            //                exit = "Тринадцать";
            //                break;
            //            case 4:
            //                exit = "Четырнадцать";
            //                break;
            //            case 5:
            //                exit = "Пятнадцать";
            //                break;
            //            case 6:
            //                exit = "Шеснадцать";
            //                break;
            //            case 7:
            //                exit = "Семнадцать";
            //                break;
            //            case 8:
            //                exit = "Восемнадцать";
            //                break;
            //            case 9:
            //                exit = "Девятнадцать";
            //                break;
            //            default:
            //                exit = "";
            //                break;
            //        }
            //        break;
            //    case 2:
            //        str = "Двадцать";
            //        exit = Quest_5V2_2(remainder, str);
            //        break;
            //    case 3:
            //        str = "Тридцать";
            //        exit = Quest_5V2_2(remainder, str);
            //        break;
            //    case 4:
            //        str = "Сорок";
            //        exit = Quest_5V2_2(remainder, str);
            //        break;
            //    case 5:
            //        str = "Пятьдесят";
            //        exit = Quest_5V2_2(remainder, str);
            //        break;
            //    case 6:
            //        str = "Шестьдесят";
            //        exit = Quest_5V2_2(remainder, str);
            //        break;
            //    case 7:
            //        str = "Семьдесят";
            //        exit = Quest_5V2_2(remainder, str);
            //        break;
            //    case 8:
            //        str = "Восемьдесят";
            //        exit = Quest_5V2_2(remainder, str);
            //        break;
            //    case 9:
            //        str = "Девяноста";
            //        exit = Quest_5V2_2(remainder, str);
            //        break;
            //    default:
            //        exit = "";
            //        break;
            //}
            //Console.WriteLine($"Введеное число: {exit}");
        }
        //static double[] Quest_5V2_2(int remainder, string str)
        //{
        //    double[] tmp = new double[1];
        //    tmp[0] = (5 * programClass.dataQueriesClass.Number_1 + programClass.dataQueriesClass.Number_2 * programClass.dataQueriesClass.Number_2) /
        //        (programClass.dataQueriesClass.Number_2 - programClass.dataQueriesClass.Number_1);
        //    return tmp; 
        //    //string exit;
        //    //switch (remainder)
        //    //{
        //    //    case 0:
        //    //        exit = str;
        //    //        break;
        //    //    case 1:
        //    //        exit = str + " один";
        //    //        break;
        //    //    case 2:
        //    //        exit = str + " два";
        //    //        break;
        //    //    case 3:
        //    //        exit = str + " три";
        //    //        break;
        //    //    case 4:
        //    //        exit = str + " четыре";
        //    //        break;
        //    //    case 5:
        //    //        exit = str + " пять";
        //    //        break;
        //    //    case 6:
        //    //        exit = str + " шесть";
        //    //        break;
        //    //    case 7:
        //    //        exit = str + " семь";
        //    //        break;
        //    //    case 8:
        //    //        exit = str + " восемь";
        //    //        break;
        //    //    case 9:
        //    //        exit = str + " девять";
        //    //        break;
        //    //    default:
        //    //        exit = "";
        //    //        break;
        //    //}
        //    //return exit;
        //}
    }
}
