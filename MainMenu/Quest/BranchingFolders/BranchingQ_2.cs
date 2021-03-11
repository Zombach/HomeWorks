namespace MainMenu.Quest.BranchingFolders
{
    public static class BranchingQ_2
    {
        public static double[] Quest(ProgramClass programClass)
        {
            programClass.dataTextClass.answerString = 4;
            double[] tmp = new double[1];
            if (programClass.dataQueriesClass.number_1 > 0)
            {
                if (programClass.dataQueriesClass.number_2 > 0)
                {
                    tmp[0] = 1;
                }
                else
                {
                    tmp[0] = 4;
                    programClass.dataTextClass.answerString += 3;
                }
            }
            else if (programClass.dataQueriesClass.number_1 < 0)
            {
                if (programClass.dataQueriesClass.number_2 > 0)
                {
                    tmp[0] = 2;
                    programClass.dataTextClass.answerString++;
                }
                else
                {
                    tmp[0] = 3;
                    programClass.dataTextClass.answerString += 2;
                }
            }
            else if (programClass.dataQueriesClass.number_1 == 0 ||
                programClass.dataQueriesClass.number_2 == 0)
            {
                tmp = null;
                programClass.dataTextClass.answerString += 4;
            }        
            return tmp;
        }
    }
}
