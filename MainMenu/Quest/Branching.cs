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
            programClass.dataTextClass.answerString = 10;
            double[] tmp = new double[2];
            tmp[0] = programClass.dataQueriesClass.number_2 * 2 - 4 * programClass.dataQueriesClass.number_1 * programClass.dataQueriesClass.number_3;

            if (programClass.dataQueriesClass.number_1 != 0)
            {
                if (tmp[0] > 0)
                {
                    tmp[0] = (-programClass.dataQueriesClass.number_2 + Math.Sqrt(tmp[0])) / (2 * programClass.dataQueriesClass.number_1);
                    tmp[1] = (-programClass.dataQueriesClass.number_2 - Math.Sqrt(tmp[0])) / (2 * programClass.dataQueriesClass.number_1);
                }
                else if (tmp[0] == 0)
                {
                    double[] tmp2 = new double[1];
                    tmp2[0] = -programClass.dataQueriesClass.number_2 / (2 * programClass.dataQueriesClass.number_1);
                }
                else
                {
                    programClass.dataTextClass.answerString++;
                    tmp = null;
                }
            }
            else
            {
                programClass.dataTextClass.answerString +=2;
                tmp = null;
            }
            return tmp;
        }
        private static double[] Quest_5(ProgramClass programClass)
        {
            double[] tmp = new double[2];
            tmp[0] = programClass.dataQueriesClass.number_1;
            if (tmp[0] < 10 || tmp[0] > 99) Console.WriteLine("Вы ввели не правильное число");
            else if (tmp[0] > 9 && tmp[0] < 20)
            {
                double[] tmp2 = new double[1];
                tmp2[0] = (int)tmp[0] % 10;
                if (tmp2[0] == 0) tmp2[0] = 0;
                else if (tmp2[0] == 1) tmp2[0] = 1;
                else if (tmp2[0] == 2) tmp2[0] = 2;
                else if (tmp2[0] == 3) tmp2[0] = 3;
                else if (tmp2[0] == 4) tmp2[0] = 4;
                else if (tmp2[0] == 5) tmp2[0] = 5;
                else if (tmp2[0] == 6) tmp2[0] = 6;
                else if (tmp2[0] == 7) tmp2[0] = 7;
                else if (tmp2[0] == 8) tmp2[0] = 8;
                else if (tmp2[0] == 9) tmp2[0] = 9;
                return tmp2;
            }
            else
            {
                tmp[1] = (int) tmp[0] / 10;
                tmp[0] = (int) tmp[0] % 10;
                if (tmp[0] == 0)
                {
                    double[] tmp3 = new double[1];
                    tmp3[0] = tmp[1];
                    tmp3[0] += 8;
                    return tmp3;
                }
                tmp[1] += 8;
                tmp[0] += 17;
            }
            return tmp;
        }               
    }
}
