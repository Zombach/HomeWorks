using System;
using MainMenu.Text;

namespace MainMenu.Quest.VariablesFolders
{
    public static class Variables_Q1
    {
        public static double[] Quest(ProgramClass programClass)
        {
            if (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1 == 0)
            {
                throw new DivideByZeroException("Делить на 0 нельзя");
            }
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
        }
    }
}
