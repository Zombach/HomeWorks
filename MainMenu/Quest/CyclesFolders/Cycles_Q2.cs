using System;

namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q2
    {
        public static double[] Quest(ProgramClass programClass)
        {
            int j = 0;
            double[] tmp = new double[1000];
            for (int i = 1; i <= 1000; i++)
            {
                if (i % programClass.dataQueriesClass.number_1 == 0)
                {
                    tmp[j++] = i;
                }
            }
            double[] tmp2 = new double[j];
            Array.Copy(tmp, tmp2, j);
            return tmp2;
        }        
    }
}
