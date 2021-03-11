namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q7
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            do
            {
                if (programClass.dataQueriesClass.number_1 > programClass.dataQueriesClass.number_2 &&
                    programClass.dataQueriesClass.number_1 != 0 && programClass.dataQueriesClass.number_2 != 0)
                {
                    programClass.dataQueriesClass.number_1 %= programClass.dataQueriesClass.number_2;
                }
                else if (programClass.dataQueriesClass.number_1 < programClass.dataQueriesClass.number_2 &&
                    programClass.dataQueriesClass.number_1 != 0 && programClass.dataQueriesClass.number_2 != 0)
                {
                    programClass.dataQueriesClass.number_2 %= programClass.dataQueriesClass.number_1;
                }
                else
                {                    
                    break;
                }                
            }
            while (programClass.dataQueriesClass.number_1 != 0 && programClass.dataQueriesClass.number_2 != 0);
            if (programClass.dataQueriesClass.number_1 == 0)
            {
                tmp[0] = programClass.dataQueriesClass.number_2;
            }
            if (programClass.dataQueriesClass.number_2 == 0)
            {
                tmp[0] = programClass.dataQueriesClass.number_1;
            }            
            return tmp;
        }
    }
}
