using System;
using MainMenu.Text;
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
                    tmp = VariablesQ_2.Quest(programClass);
                    break;
                case 3:
                    tmp = VariablesQ_3.Quest(programClass);
                    break;
                case 4:
                    tmp = VariablesQ_4.Quest(programClass);
                    break;
                case 5:
                    tmp = VariablesQ_5.Quest(programClass);
                    break;
                default:
                    break;
            }
            return tmp;
        }
    }
}
