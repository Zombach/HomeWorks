using MainMenu.Quest.ArraySingleFolders;
using MainMenu.Quest.GenerateMassive;

namespace MainMenu.Quest
{
    public static class ArraySingle
    {
        public static double[] QuestAll(ProgramClass programClass)
        {
            int[] ints;
            double[] tmp = null;
            switch (programClass.dataTextY)
            {
                case 1:
                    ints = GenerateMassive_Single.MassiveToQAll(programClass);
                    tmp = ArraySingle_Q1.Quest(ints);
                    break;
                case 2:
                    ints = GenerateMassive_Single.MassiveToQAll(programClass);
                    tmp = ArraySingle_Q2.Quest(ints);
                    break;
                case 3:
                    ints = GenerateMassive_Single.MassiveToQAll(programClass);
                    tmp = ArraySingle_Q3.Quest(ints);
                    break;
                case 4:
                    ints = GenerateMassive_Single.MassiveToQAll(programClass);
                    tmp = ArraySingle_Q4.Quest(ints);
                    break;
                case 5:
                    ints = GenerateMassive_Single.MassiveToQAll(programClass);
                    tmp = ArraySingle_Q5.Quest(ints);
                    break;
                case 6:
                    ints = GenerateMassive_Single.MassiveToQAll(programClass);
                    tmp = ArraySingle_Q6.Quest(ints);
                    break;
                case 7:
                    ints = GenerateMassive_Single.MassiveToQAll(programClass);
                    tmp = ArraySingle_Q7.Quest(ints);
                    break;
                case 8:
                    ints = GenerateMassive_Single.MassiveToQAll(programClass);
                    tmp = ArraySingle_Q8.Quest(ints);
                    break;
                case 9:
                    ints = GenerateMassive_Single.MassiveToQAll(programClass);
                    tmp = ArraySingle_Q9.Quest(ints);
                    break;
                case 10:
                    ints = GenerateMassive_Single.MassiveToQAll(programClass);
                    tmp = ArraySingle_Q10.Quest(ints);
                    break;
                default:
                    break;
            }
            return tmp;
        }        
    }
}
