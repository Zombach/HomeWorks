namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q6
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            programClass.dataQueriesClass.number_2 = 1;
            programClass.dataQueriesClass.number_3 = 1;
            if (programClass.dataQueriesClass.number_1 == 1 || programClass.dataQueriesClass.number_1 == 2)
            {
                tmp[0] = 1;
                return tmp;
            }

            for (int i = 2; i < programClass.dataQueriesClass.number_1; i++)
            {
                tmp[0] = programClass.dataQueriesClass.number_2 + programClass.dataQueriesClass.number_3;
                programClass.dataQueriesClass.number_2 = programClass.dataQueriesClass.number_3;
                programClass.dataQueriesClass.number_3 = (int)tmp[0];
            }
            return tmp;
        }
    }
}
