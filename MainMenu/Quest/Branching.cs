using System;
using System.Collections.Generic;
using System.Text;
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
                    tmp = BranchingQ_1.Quest(programClass);
                    break;
                case 2:
                    tmp = BranchingQ_2.Quest(programClass);
                    break;
                case 3:
                    tmp = BranchingQ_3.Quest(programClass);
                    break;
                case 4:
                    tmp = BranchingQ_4.Quest(programClass);
                    break;
                case 5:
                    tmp = BranchingQ_5.Quest(programClass);
                    break;
                default:
                    break;
            }
            return tmp;
        }            
    }
}
