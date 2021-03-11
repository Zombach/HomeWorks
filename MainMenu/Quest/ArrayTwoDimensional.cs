using MainMenu.Quest.ArrayTwoDimensionalFolders;

namespace MainMenu.Quest
{
    public static class ArrayTwoDimensional
    {
        public static double[] QuestAll(ProgramClass programClass)
        {
            double[] tmp = null;
            switch (programClass.dataTextY)
            {
                case 1:
                    tmp = ArrayTwoDimensional_Q1.Quest(programClass);
                    break;
                case 2:
                    tmp = ArrayTwoDimensional_Q2.Quest(programClass);
                    break;
                case 3:
                    tmp = ArrayTwoDimensional_Q3.Quest(programClass);
                    break;
                case 4:
                    tmp = ArrayTwoDimensional_Q4.Quest(programClass);
                    break;
                case 5:
                    tmp = ArrayTwoDimensional_Q5.Quest(programClass);
                    break;
                case 6:
                    tmp = ArrayTwoDimensional_Q6.Quest(programClass);
                    break;
                default:
                    break;
            }
            return tmp;
        }
    }
}