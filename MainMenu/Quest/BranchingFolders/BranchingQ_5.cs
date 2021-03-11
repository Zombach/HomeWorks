using System;

namespace MainMenu.Quest.BranchingFolders
{
    public static class BranchingQ_5
    {
        public static double[] Quest(ProgramClass programClass)
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
