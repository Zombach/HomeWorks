using MainMenu.Quest.ArrayTwoDimensionalFolders;
using MainMenu.Quest.GenerateMassive;

namespace MainMenu.Quest
{
    public static class ArrayTwoDimensional
    {
        public static double[] QuestAll(ProgramClass programClass)
        {
            int[,] ints;
            double[] tmp = null;
            switch (programClass.dataTextY)
            {
                case 1:
                    ints = GenerateMassive_TwoDimensional.MassiveToQAll(programClass);
                    tmp = ArrayTwoDimensional_Q1.Quest(ints);
                    break;
                case 2:
                    ints = GenerateMassive_TwoDimensional.MassiveToQAll(programClass);
                    tmp = ArrayTwoDimensional_Q2.Quest(ints);
                    break;
                case 3:
                    ints = GenerateMassive_TwoDimensional.MassiveToQAll(programClass);
                    tmp = ArrayTwoDimensional_Q3.Quest(ints);
                    break;
                case 4:
                    ints = GenerateMassive_TwoDimensional.MassiveToQAll(programClass);
                    tmp = ArrayTwoDimensional_Q4.Quest(ints);
                    break;
                case 5:
                    ints = GenerateMassive_TwoDimensional.MassiveToQAll(programClass);
                    tmp = ArrayTwoDimensional_Q5.Quest(ints);
                    break;
                case 6:
                    Quest6(programClass);
                    break;
                default:
                    break;
            }
            return tmp;
        }
        public static void Quest6(ProgramClass programClass)
        {
            int[,] ints;
            int[,] tmp = null;
            ints = GenerateMassive_TwoDimensional.MassiveToQAll(programClass);
            tmp = ArrayTwoDimensional_Q6.Quest(ints);
        }
    }
}