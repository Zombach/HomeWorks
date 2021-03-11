using MainMenu.Quest.CyclesFolder;

namespace MainMenu.Quest
{
    public static class Cycles
    {
        public static double[] QuestAll(ProgramClass programClass)
        {
            double[] tmp = null;
            switch (programClass.dataTextY)
            {
                case 1:
                    tmp = Cycles_Q1.Quest(programClass);
                    break;
                case 2:
                    tmp = Cycles_Q2.Quest(programClass);
                    break;
                case 3:
                    tmp = Cycles_Q3.Quest(programClass);
                    break;
                case 4:
                    tmp = Cycles_Q4.Quest(programClass);
                    break;
                case 5:
                    tmp = Cycles_Q5.Quest(programClass);
                    break;
                case 6:
                    tmp = Cycles_Q6.Quest(programClass);
                    break;
                case 7:
                    tmp = Cycles_Q7.Quest(programClass);
                    break;
                case 8:
                    tmp = Cycles_Q8.Quest(programClass);
                    break;
                case 9:
                    tmp = Cycles_Q9.Quest(programClass);
                    break;
                case 10:
                    tmp = Cycles_Q10.Quest(programClass);
                    break;
                case 11:
                    tmp = Cycles_Q11.Quest(programClass);
                    break;
                case 12:
                    tmp = Cycles_Q12.Quest(programClass);
                    break;
                default:
                    break;
            } 
            return tmp;
        }        
    }
}
