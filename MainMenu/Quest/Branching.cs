using MainMenu.Quest.BranchingFolders;

namespace MainMenu.Quest
{
    public static class Branching
    {
        public static double[] QuestAll(ProgramClass programClass)
        {
            double[] tmp = null;
            switch (programClass.dataTextY)
            {
                case 1:
                    tmp = Branching_Q1.Quest(programClass);
                    break;
                case 2:
                    tmp = Branching_Q2.Quest(programClass);
                    break;
                case 3:
                    tmp = Branching_Q3.Quest(programClass);
                    break;
                case 4:
                    tmp = Branching_Q4.Quest(programClass);
                    break;
                case 5:
                    tmp = Branching_Q5.Quest(programClass);
                    break;
                default:
                    break;
            }
            return tmp;
        }            
    }
}
