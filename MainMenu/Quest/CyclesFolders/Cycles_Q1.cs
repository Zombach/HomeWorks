namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q1
    {        
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = 1;
            for (int i = 0; i < programClass.dataQueriesClass.number_2; i++)
            {
                tmp[0] *= programClass.dataQueriesClass.number_1;
            }
            for (int i = 0; i > programClass.dataQueriesClass.number_2; i--)
            {
                tmp[0] /= programClass.dataQueriesClass.number_1;
            }
            return tmp;
        }        
    }
}
