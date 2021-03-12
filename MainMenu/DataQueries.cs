using System;
using System.Collections.Generic;
using System.Text;
using MainMenu.Quest;

namespace MainMenu
{
    public class DataQueriesClass
    {
        public int queriesData;
        public int number_1;
        public int number_2;
        public int number_3;
        public int number_4;
    }
    public static class DataQueries
    {
        public static DataQueriesClass DataQueriesC()
        {
            DataQueriesClass dataQueriesClass = new DataQueriesClass();
            dataQueriesClass.queriesData = 0;
            dataQueriesClass.number_1 = 0;
            dataQueriesClass.number_2 = 0;
            dataQueriesClass.number_3 = 0;
            dataQueriesClass.number_4 = 0;
            return dataQueriesClass;
        }
        public static DataQueriesClass DQC_QueriesData(ProgramClass programClass, int queriesData = 0)
        {
            programClass.dataQueriesClass.queriesData = queriesData;
            return programClass.dataQueriesClass;
        }
        public static DataQueriesClass DQC_Number_1(ProgramClass programClass, int number_1)
        {
            programClass.dataQueriesClass.number_1 = number_1;
            return programClass.dataQueriesClass;
        }
        public static DataQueriesClass DQC_Number_2(ProgramClass programClass, int number_2)
        {
            programClass.dataQueriesClass.number_2 = number_2;
            return programClass.dataQueriesClass;
        }
        public static DataQueriesClass DQC_Number_3(ProgramClass programClass, int number_3)
        {
            programClass.dataQueriesClass.number_3 = number_3;
            return programClass.dataQueriesClass;
        }
        public static DataQueriesClass DQC_Number_4(ProgramClass programClass, int number_4)
        {
            programClass.dataQueriesClass.number_4 = number_4;
            return programClass.dataQueriesClass;
        }
        public static int QueriesDataAll(ProgramClass programClass)
        {
            int QueriesData = 0;
            switch (programClass.section)
            {
                case 1:
                    QueriesData = QueriesDataVariables(programClass);
                    break;
                case 2:
                    QueriesData = QueriesDataBranching(programClass);
                    break;
                case 3:
                    QueriesData = QueriesDataCycles(programClass);
                    break;
                case 4:
                    QueriesData = QueriesDataArraySingle(programClass);
                    break;
                case 5:
                    QueriesData = QueriesDataArrayTwoDimensional(programClass);
                    break;
                default:
                    break;
            }
            return QueriesData;
        }
        private static int QueriesDataVariables(ProgramClass programClass)
        {
            int count = 0;
            switch (programClass.dataTextY)
            {
                case 1:
                    count = 2;
                    break;
                case 2:
                    count = 2;
                    break;
                case 3:
                    count = 2;
                    break;
                case 4:
                    count = 3;
                    break;
                case 5:
                    programClass.dataTextClass.comPhraseString = 3;
                    programClass.dataTextClass.answerString += 2;
                    count = 4;
                    break;
                default:
                    break;
            }
            return count;
        }
        private static int QueriesDataBranching(ProgramClass programClass)
        {
            int count = 0;
            switch (programClass.dataTextY)
            {
                case 1:
                    count = 2;
                    break;
                case 2:
                    programClass.dataTextClass.comPhraseString = 3;
                    count = 2;
                    break;
                case 3:
                    count = 3;
                    break;
                case 4:
                    count = 3;
                    break;
                case 5:
                    count = 1;
                    break;
                default:
                    break;
            }
            return count;
        }
        private static int QueriesDataCycles(ProgramClass programClass)
        {
            int count = 0;
            switch (programClass.dataTextY)
            {
                case 1:
                    count = 2;
                    break;
                case 2:
                    count = 1;
                    break;
                case 3:
                    count = 1;
                    break;
                case 4:
                    count = 1;
                    break;
                case 5:
                    count = 2;
                    break;
                case 6:
                    count = 1;
                    break;
                case 7:
                    count = 2;
                    break;
                case 8:
                    count = 1;
                    break;
                case 9:
                    count = 1;
                    break;
                case 10:
                    count = 1;
                    break;
                case 11:
                    count = 1;
                    break;
                case 12:
                    count = 1;
                    break;
                default:
                    break;
            }
            return count;
        }
        private static int QueriesDataArraySingle(ProgramClass programClass)
        {
            int count = 0;
            switch (programClass.dataTextY)
            {
                case 1:
                    programClass.dataTextClass.comPhraseString = 8;
                    count = 2;
                    break;
                case 2:
                    count = 2;
                    break;
                case 3:
                    count = 2;
                    break;
                case 4:
                    count = 2;
                    break;
                case 5:
                    count = 2;
                    break;
                case 6:
                    count = 2;
                    break;
                case 7:
                    count = 2;
                    break;
                case 8:
                    count = 2;
                    break;
                case 9:
                    count = 2;
                    break;
                case 10:
                    count = 2;
                    break;        
                default:
                    break;
            }
            return count;
        }
        private static int QueriesDataArrayTwoDimensional(ProgramClass programClass)
        {
            int count = 0;
            switch (programClass.dataTextY)
            {
                case 1:
                    count = 2;
                    break;
                case 2:
                    count = 2;
                    break;
                case 3:
                    count = 2;
                    break;
                case 4:
                    count = 2;
                    break;
                case 5:
                    count = 2;
                    break;
                case 6:
                    count = 2;
                    break;
                default:
                    break;
            }
            return count;
        }
    }
}
