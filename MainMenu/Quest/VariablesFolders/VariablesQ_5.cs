﻿using System;
using MainMenu.Text;

namespace MainMenu.Quest.VariablesFolders
{
    public static class VariablesQ_5
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[2];
            tmp[0] = (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_4) / (programClass.dataQueriesClass.number_1 - programClass.dataQueriesClass.number_3);
            tmp[1] = programClass.dataQueriesClass.number_4 - tmp[0] * programClass.dataQueriesClass.number_2;
            return tmp;
        }
    }
}