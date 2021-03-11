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
            }
            tmp[0] = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < tmp[0])
                {
                    tmp[0] = ints[i];
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
            int[] ints = new int[programClass.dataQueriesClass.number_1];
            for (int i = 1; i <= ints.Length; i++)
            {
                ints[i - 1] = -i * programClass.dataQueriesClass.number_2 + programClass.dataQueriesClass.number_1;
                Console.WriteLine(ints[i - 1]);
            }
            int tmp2 = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < tmp2)
                {
                    tmp2 = ints[i];
                    tmp[0] = i;
                }
            }
            return tmp;
        }

        private static double[] Quest_4(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            int[] ints = new int[programClass.dataQueriesClass.number_1];
            for (int i = 1; i <= ints.Length; i++)
            {
                ints[i - 1] = i * programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1;
            }
            int tmp2 = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > tmp2)
                {
                    tmp2 = ints[i];
                    tmp[0] = i;
                }
            }
            return tmp;
        }

        private static double[] Quest_5(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            int[] ints = new int[programClass.dataQueriesClass.number_1];
            for (int i = 1; i <= ints.Length; i++)
            {
                ints[i - 1] = i * programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1;
            }
            for (int i = 0; i < ints.Length; i++)
            {
                if (i % 2 != 0)
                {
                    tmp[0] += ints[i];
                }
            }
            return tmp;
        }

        private static double[] Quest_6(ProgramClass programClass)
        {
            double[] tmp = new double[programClass.dataQueriesClass.number_1];
            int[] ints = new int[programClass.dataQueriesClass.number_1];
            for (int i = 1; i <= ints.Length; i++)
            {
                ints[i - 1] = i * programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1;
            }
            for (int i = 0; i < ints.Length; i++)
            {
                    tmp[tmp.Length - 1 - i] = ints[i];
            }
            return tmp;
        }

        private static double[] Quest_7(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            int[] ints = new int[programClass.dataQueriesClass.number_1];
            for (int i = 1; i <= ints.Length; i++)
            {
                ints[i - 1] = i * programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1;
            }
            tmp[0] = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 != 0)
                {
                    tmp[0]++;
                }
            }
            return tmp;
        }

        private static double[] Quest_8(ProgramClass programClass)
        {
            double[] tmp = new double[programClass.dataQueriesClass.number_1];
            int[] ints = new int[programClass.dataQueriesClass.number_1];
            for (int i = 1; i <= ints.Length; i++)
            {
                ints[i - 1] = i * programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1;
            }
            int tmp3 = 0;
            if (ints.Length % 2 != 0)
            {
                tmp3 = 1;
            }
            int tmp2 = ints.Length / 2;
            for (int i = 0; i < tmp2; i++)
            {
                tmp[i] = ints[tmp2 + tmp3 + i];
                tmp[tmp2 + tmp3 + i] = ints[i];
            }
            return tmp;
        }

        private static double[] Quest_9(ProgramClass programClass)
        {
            double[] tmp = new double[programClass.dataQueriesClass.number_1];
            int[] ints = new int[programClass.dataQueriesClass.number_1];
            for (int i = 1; i <= ints.Length; i++)
            {
                ints[i - 1] = i * programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1;
            }
            int tmp2 = 0;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                tmp2 = ints[i];
                for (int j = 1 + i; j < ints.Length; j++)
                {
                    if (ints[i] > ints[j])
                    {
                        tmp2 = ints[i];
                        ints[i] = ints[j];
                        ints[j] = tmp2;
                    }
                    Console.Write("Проверка = " + ints[i]);
                }
            }
            tmp.CopyTo(ints, 0);
            return tmp;
        }

        private static double[] Quest_10(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            int[] ints = new int[programClass.dataQueriesClass.number_1];
            for (int i = 1; i <= ints.Length; i++)
            {
                ints[i - 1] = i * programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1;
            }

            int tmp2 = 0;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] < ints[i + 1])
                {
                    tmp2 = ints[i];
                    ints[i] = ints[i + 1];
                    ints[i + 1] = tmp2;
                    for (int j = i; j > 0; j--)
                    {
                        if (j < 0)
                        {
                            break;
                        }
                        else if (ints[j - 1] < ints[j])
                        {
                            tmp2 = ints[j];
                            ints[j] = ints[j - 1];
                            ints[j - 1] = tmp2;
                        }
                        else break;
                    }
                }
            }
            tmp.CopyTo(ints, 0);
            return tmp;
        }
    }
}
