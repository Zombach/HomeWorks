namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q4
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            for (int i = programClass.dataQueriesClass.number_1 - 1; i > 0; i--)
            {
                if (programClass.dataQueriesClass.number_1 % i == 0)
                {
                    tmp[0] = i;
                    break;
                }
            }
            return tmp;
        }        
    }
}
