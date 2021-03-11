namespace MainMenu.Quest.BranchingFolders
{
    public static class BranchingQ_3
    {
        public static double[] Quest(ProgramClass programClass)
        {
            programClass.dataTextClass.answerString = 9;
            double[] tmp = new double[3];
            if (programClass.dataQueriesClass.number_1 > programClass.dataQueriesClass.number_2)
            {
                tmp[0] = programClass.dataQueriesClass.number_1;
                programClass.dataQueriesClass.number_1 = programClass.dataQueriesClass.number_2;
                programClass.dataQueriesClass.number_2 = (int )tmp[0];
            }
            if (programClass.dataQueriesClass.number_1 > programClass.dataQueriesClass.number_3)
            {
                tmp[1] = programClass.dataQueriesClass.number_1;
                programClass.dataQueriesClass.number_1 = programClass.dataQueriesClass.number_3;
                programClass.dataQueriesClass.number_3 = (int)tmp[1];
            }
            if (programClass.dataQueriesClass.number_2 > programClass.dataQueriesClass.number_3)
            {
                tmp[2] = programClass.dataQueriesClass.number_2;
                programClass.dataQueriesClass.number_2 = programClass.dataQueriesClass.number_3;
                programClass.dataQueriesClass.number_3 = (int)tmp[2];
            }
            tmp[0] = programClass.dataQueriesClass.number_1;
            tmp[1] = programClass.dataQueriesClass.number_2;
            tmp[2] = programClass.dataQueriesClass.number_3;
            return tmp;
        }                
    }
}
