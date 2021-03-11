namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q5
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            if (programClass.dataQueriesClass.number_1 > programClass.dataQueriesClass.number_2)
            {
                tmp[0] = programClass.dataQueriesClass.number_1;
                programClass.dataQueriesClass.number_1 = programClass.dataQueriesClass.number_2;
                programClass.dataQueriesClass.number_2 = (int)tmp[0];
            }
            tmp[0] = 0;
            for (int i = programClass.dataQueriesClass.number_1 + 1; i < programClass.dataQueriesClass.number_2; i++)
            {
                if (i % 7 == 0)
                {
                    tmp[0] += i;
                }
            }
            return tmp;
        }
    }
}
