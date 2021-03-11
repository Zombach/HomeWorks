using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu.Quest.GenerateMassive
{
    public static class GenerateMassive_Single
    {
        public static int[] MassiveToQAll(ProgramClass programClass)
        {
            int[] tmp = new int[programClass.dataQueriesClass.number_1];
            int tmp2 = tmp.Length / 2;
            for (int i = 1; i <= tmp.Length; i++)
            {
                if (i <= tmp2)
                {
                    tmp[i - 1] = i * programClass.dataQueriesClass.number_2 + programClass.dataQueriesClass.number_1;
                }
                else
                {
                    tmp[i - 1] = -i * programClass.dataQueriesClass.number_2 + programClass.dataQueriesClass.number_1;
                }
            }
            return tmp;
        }
    }
}
