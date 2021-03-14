using System;
using MainMenu.Text;

namespace MainMenu.Quest.VariablesFolders
{
    public static class Variables_Q3
    {
        public static double[] Quest(ProgramClass programClass)
        {
            if (programClass.dataQueriesClass.number_2 == 0)
            {
                throw new DivideByZeroException("Делить на 0 нельзя");
            }
            double[] tmp = new double[2];
            tmp[0] = programClass.dataQueriesClass.number_1 / programClass.dataQueriesClass.number_2;
            tmp[1] = programClass.dataQueriesClass.number_1 % programClass.dataQueriesClass.number_2;
            return tmp;
        }
    }
}
