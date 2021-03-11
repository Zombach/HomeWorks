using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu.Quest.GenerateMassive
{
    public static class GenerateMassive_TwoDimensional
    {
        public static int[,] MassiveToQAll(ProgramClass programClass)
        {
            int[,] tmp = new int[programClass.dataQueriesClass.number_1, programClass.dataQueriesClass.number_2];
            int tmp2 = tmp.GetLength(0) / 2;
            for (int i = 1; i <= tmp.GetLength(0); i++)
            {
                for(int j = 1; j < tmp.GetLength(1); j++)
                if (i <= tmp2)
                {
                    tmp[i - 1, j - 1] = -i * programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1;
                }
                else
                {
                    tmp[i - 1, j - 1] = i * programClass.dataQueriesClass.number_2 + programClass.dataQueriesClass.number_1;
                }
            }
            return tmp;
        }
    }
}
