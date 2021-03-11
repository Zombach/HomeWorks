using MainMenu.Quest.VariablesFolders;

namespace MainMenu.Quest
{
    public static class Variables
    {
        public static double[] QuestAll(ProgramClass programClass)
        {
            double[] tmp = null;
            switch (programClass.dataTextY)
            {
                case 1:
                    tmp = VariablesQ_1.Quest(programClass);
                    break;
                case 2:
                    tmp = Variables_Q2.Quest(programClass);
                    break;
                case 3:
                    tmp = Variables_Q3.Quest(programClass);
                    break;
                case 4:
                    tmp = Variables_Q4.Quest(programClass);
                    break;
                case 5:
                    tmp = Variables_Q5.Quest(programClass);
                    break;                
                default:
                    break;
            }
            return tmp;
        }
    }
}
