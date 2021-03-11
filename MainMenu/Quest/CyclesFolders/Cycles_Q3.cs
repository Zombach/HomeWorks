namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q3
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = 0;
            for (int i = 1; i <= programClass.dataQueriesClass.number_1; i++)
            {
                if (programClass.dataQueriesClass.number_1 > i * i)
                {
                    tmp[0]++;
                }
                else break;
            }
            return tmp;            
        }
    }
}
