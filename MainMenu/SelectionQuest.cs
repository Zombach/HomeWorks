using System;
using System.Collections.Generic;
using System.Text;
using MainMenu.Quest;
using MainMenu.Text;

namespace MainMenu
{
    public static class SelectionQuest
    {
        public static ProgramClass SelectSection(ProgramClass programClass)
        {
            switch (programClass.dataTextX)
            {
                case 1:
                    programClass.dataTextX = 1;
                    programClass.dataTextClass.answer = 2;
                    break;
                case 2:
                    programClass.dataTextX = 3;
                    programClass.dataTextClass.answer = 4;
                    break;
                case 3:
                    programClass.dataTextX = 5;
                    programClass.dataTextClass.answer = 6;
                    break;
                case 4:
                    programClass.dataTextX = 7;
                    programClass.dataTextClass.answer = 8;
                    break;
                case 5:
                    programClass.dataTextX = 9;
                    programClass.dataTextClass.answer = 10;
                    break;
                case 6:
                    Console.WriteLine("ВЫХОД");
                    break;
                default:
                    programClass.dataTextX = 0;
                    Console.WriteLine($"РАЗДЕЛ № {programClass.dataTextX}, не существует, выберите существующий раздел");
                    break;
            }
            return programClass;
        }
        public static void QuestStart(string[][] dataText, ProgramClass programClass)
        {
            int queriesData = DataQueries.QueriesDataAll(programClass);
            programClass.dataQueriesClass = DataQueries.DQC_QueriesData(programClass, queriesData);
            programClass.dataTextClass = DataText.DTC_СomPhrase(programClass);
            int number_1 = ConsoleInPut.InPutInForQuest(dataText, programClass);
            programClass.dataTextClass.comPhraseString++;
            programClass.dataQueriesClass = DataQueries.DQC_Number_1(programClass, number_1);

            if (queriesData >= 2)
            {
                int number_2 = ConsoleInPut.InPutInForQuest(dataText, programClass);
                programClass.dataTextClass.comPhraseString++;
                programClass.dataQueriesClass = DataQueries.DQC_Number_2(programClass, number_2);
            }

            if (queriesData >= 3)
            {
                int number_3 = ConsoleInPut.InPutInForQuest(dataText, programClass);
                programClass.dataTextClass.comPhraseString++;
                programClass.dataQueriesClass = DataQueries.DQC_Number_3(programClass, number_3);
            }

            if (queriesData == 4)
            {
                int number_4 = ConsoleInPut.InPutInForQuest(dataText, programClass);
                programClass.dataTextClass.comPhraseString++;
                programClass.dataQueriesClass = DataQueries.DQC_Number_4(programClass, number_4);
            }
            if (programClass.dataTextY == 5 && programClass.section == 2)
            {
                double[] tmp = CalculationsSections(programClass);
                Fill_In.DataStringTo_2_5(dataText, programClass, tmp);
            }

            if (programClass.dataTextY != 5 || programClass.section != 2)
            {
                string result = Calculations(programClass);            
                if (result != null)
                {
                    Fill_In.DataOutputString(dataText, programClass, result);
                }
                else
                {
                    Fill_In.StringOut(dataText, programClass);
                }
            }
            //string resultTmp = Calculations(programClass);
        }

        private static string Calculations(ProgramClass programClass)
        {
            double[] tmp = CalculationsSections(programClass);
            string result = ConvertResult(tmp);
            return result;
        }

        private static double[] CalculationsSections(ProgramClass programClass)
        {
            double[] tmp = null;
            switch (programClass.section)
            {
                case 1:
                    tmp = Variables.QuestAll(programClass);
                    break;
                case 2:
                    tmp = Branching.QuestAll(programClass);
                    break;
                case 3:
                    tmp = Cycles.QuestAll(programClass);
                    break;
                case 4:
                    tmp = ArraySingle.QuestAll(programClass);
                    break;
                case 5:
                    tmp = ArrayTwoDimensional.QuestAll(programClass);
                    break;
                default:
                    break;
            }
            return tmp;
        }

        private static string ConvertResult(double[] tmp)
        {
            string result = null;
            if (tmp != null)
            {
                for (int i = 0; i < tmp.Length; i++)
                {
                    if (i != 0 || i == tmp.Length)
                    {
                        result += " и ";
                    }
                    result += Convert.ToString(tmp[i]);
                }
            }
            return result;
        }
    }
}
