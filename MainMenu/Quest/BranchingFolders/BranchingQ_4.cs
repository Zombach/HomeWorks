﻿using System;

namespace MainMenu.Quest.BranchingFolders
{
    public static class BranchingQ_4
    {
        public static double[] Quest(ProgramClass programClass)
        {
            programClass.dataTextClass.answerString = 10;
            double[] tmp = new double[2];
            tmp[0] = programClass.dataQueriesClass.number_2 * 2 - 4 * programClass.dataQueriesClass.number_1 * programClass.dataQueriesClass.number_3;

            if (programClass.dataQueriesClass.number_1 != 0)
            {
                if (tmp[0] > 0)
                {
                    tmp[0] = (-programClass.dataQueriesClass.number_2 + Math.Sqrt(tmp[0])) / (2 * programClass.dataQueriesClass.number_1);
                    tmp[1] = (-programClass.dataQueriesClass.number_2 - Math.Sqrt(tmp[0])) / (2 * programClass.dataQueriesClass.number_1);
                }
                else if (tmp[0] == 0)
                {
                    double[] tmp2 = new double[1];
                    tmp2[0] = -programClass.dataQueriesClass.number_2 / (2 * programClass.dataQueriesClass.number_1);
                }
                else
                {
                    programClass.dataTextClass.answerString++;
                    tmp = null;
                }
            }
            else
            {
                programClass.dataTextClass.answerString +=2;
                tmp = null;
            }
            return tmp;
        }        
    }
}
