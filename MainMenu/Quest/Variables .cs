using System;
using MainMenu.Text;

namespace MainMenu.Quest
{
    public static class Variables
    {
        public static double[] QuestAll(ProgramClass programClass)
        {
            double[] tmp = null;
            switch (programClass.dataTextY)
            {
                case 1:
                    tmp = Quest_1(programClass);
                    break;
                case 2:
                    tmp = Quest_2(programClass);
                    break;
                case 3:
                    tmp = Quest_3(programClass);
                    break;
                case 4:
                    tmp = Quest_4(programClass);
                    break;
                case 5:
                    tmp = Quest_5(programClass);
                    break;
                default:
                    break;
            }
            return tmp;
        }

        private static double[] Quest_1(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
        }

        private static double[] Quest_2(ProgramClass programClass)
        {
            double[] tmp = new double[2];
            tmp[0] = programClass.dataQueriesClass.number_1;
            programClass.dataQueriesClass.number_1 = programClass.dataQueriesClass.number_2;
            programClass.dataQueriesClass.number_2 = (int)tmp[0];
            tmp[0] = programClass.dataQueriesClass.number_1;
            tmp[1] = programClass.dataQueriesClass.number_2;
            return tmp;
        }
        private static double[] Quest_3(ProgramClass programClass)
        {
            double[] tmp = new double[2];
            tmp[0] = programClass.dataQueriesClass.number_1 / programClass.dataQueriesClass.number_2;
            tmp[1] = programClass.dataQueriesClass.number_1 % programClass.dataQueriesClass.number_2;
            return tmp;
        }
        private static double[] Quest_4(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            if (programClass.dataQueriesClass.number_1 == 0)
            {
                if (programClass.dataQueriesClass.number_2 != programClass.dataQueriesClass.number_3)
                {
                    programClass.dataTextClass.answerString++;
                    tmp = null;

                }
                else
                {
                    programClass.dataTextClass.answerString++;
                    programClass.dataTextClass.answerString++;
                }
                if (tmp == null)
                {
                    
                }
                return tmp;
            }
            tmp[0] = (double) (programClass.dataQueriesClass.number_3 - programClass.dataQueriesClass.number_2) / programClass.dataQueriesClass.number_1;
            return tmp;
        }
        private static double[] Quest_5(ProgramClass programClass)
        {
            double[] tmp = new double[2];
            tmp[0] = (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_4) / (programClass.dataQueriesClass.number_1 - programClass.dataQueriesClass.number_3);
            tmp[1] = programClass.dataQueriesClass.number_4 - tmp[0] * programClass.dataQueriesClass.number_2;
            return tmp;
        }
    }
}
