namespace MainMenu.Quest.BranchingFolders
{
    public static class Branching_Q1
    {       
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            if (programClass.dataQueriesClass.number_1 > programClass.dataQueriesClass.number_2)
            {
                tmp[0] = programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2;
            }
            else if (programClass.dataQueriesClass.number_1 == programClass.dataQueriesClass.number_2)
            {
                programClass.dataTextClass.answerString++;
                tmp[0] = programClass.dataQueriesClass.number_1 * programClass.dataQueriesClass.number_2;
            }
            else if (programClass.dataQueriesClass.number_1 < programClass.dataQueriesClass.number_2)
            {
                programClass.dataTextClass.answerString++;
                programClass.dataTextClass.answerString++;
                tmp[0] = programClass.dataQueriesClass.number_1 - programClass.dataQueriesClass.number_2;
            }
            return tmp;            
        }                    
    }
}
