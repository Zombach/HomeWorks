using System;
using MainMenu.Text;

namespace MainMenu.Quest.VariablesFolders
{
    public static class Variables_Q4
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            if (programClass.dataQueriesClass.number_1 == 0)
            {
                if (programClass.dataQueriesClass.number_2 == programClass.dataQueriesClass.number_3)
                {
                    programClass.dataTextClass.answerString++;
                }
                programClass.dataTextClass.answerString++;
                tmp = null;
                return tmp;
            }
            tmp[0] = (double)(programClass.dataQueriesClass.number_3 - programClass.dataQueriesClass.number_2) / programClass.dataQueriesClass.number_1;
            return tmp;
        }
    }
}
