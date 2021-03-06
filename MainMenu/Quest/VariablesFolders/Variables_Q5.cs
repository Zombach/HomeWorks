using System;
using MainMenu.Text;

namespace MainMenu.Quest.VariablesFolders
{
    public static class Variables_Q5
    {
        public static double[] Quest(ProgramClass programClass)
        {
            if (programClass.dataQueriesClass.number_1 - programClass.dataQueriesClass.number_3 == 0)
            {
                throw new DivideByZeroException("Делить на 0 нельзя");
            }
            double[] tmp = new double[2];
            tmp[0] = (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_4) / (programClass.dataQueriesClass.number_1 - programClass.dataQueriesClass.number_3);
            tmp[1] = programClass.dataQueriesClass.number_4 - tmp[0] * programClass.dataQueriesClass.number_2;
            return tmp;
        }
    }
}
