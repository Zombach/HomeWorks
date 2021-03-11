using System;
using System.Collections.Generic;
using System.Text;
using MainMenu;

namespace MainMenu.Text
{
    public class DataTextClass
    {
        public int section;
        public int quest;
        public int comPhrase;
        public int comPhraseString;
        public int answer;
        public int answerString;
    }
    public static class DataText
    {
        public static DataTextClass DataTextC()
        {
            DataTextClass dataTextClass = new DataTextClass();
            dataTextClass.section = 0;
            dataTextClass.quest = 0;
            dataTextClass.comPhrase = 12;
            dataTextClass.comPhraseString = 0;
            dataTextClass.answer = 0;
            dataTextClass.answerString = 0;
            return dataTextClass;
        }
        public static DataTextClass DTC_Section(ProgramClass programClass)
        {
            programClass.dataTextClass.section = programClass.dataTextX;
            return programClass.dataTextClass;
        }
        public static DataTextClass DTC_Quest(ProgramClass programClass)
        {
            programClass.dataTextClass.quest = programClass.dataTextY;
            return programClass.dataTextClass;
        }
        public static DataTextClass DTC_СomPhrase(ProgramClass programClass, int comPhrase = 12)
        {
            programClass.dataTextClass.comPhrase = comPhrase;
            return programClass.dataTextClass;
        }
        public static DataTextClass DTC_СomPhraseString(ProgramClass programClass)
        {
            programClass.dataTextClass.comPhraseString = programClass.dataTextY - 1;
            return programClass.dataTextClass;
        }
        public static DataTextClass DTC_Answer(ProgramClass programClass, int answer)
        {
            programClass.dataTextClass.answer = answer;
            return programClass.dataTextClass;
        }
        public static DataTextClass DTC_AnswerString(ProgramClass programClass)
        {
            programClass.dataTextClass.answerString = programClass.dataTextY;
            return programClass.dataTextClass;
        }
        public static string[][] CreateData(string[][] dataText)
        {
            dataText = StartCreateTextData(dataText);
            dataText = TextStart.StartText(dataText);
            dataText = CreateVariables(dataText);
            dataText = CreateBranching(dataText);
            dataText = CreateCycles(dataText);
            dataText = CreateArraySingle(dataText);
            dataText = CreateArrayTwoDimensional(dataText);
            dataText = CreateNumbersInWords(dataText);
            dataText = CreatePhrasesCommon(dataText);
            return dataText;
        }
        private static string[][] StartCreateTextData(string[][] dataText, int i = 0)
        {
            dataText = new string[13][];
            dataText[i++] = new string[9];  //0
            dataText[i++] = new string[7];  //1
            dataText[i++] = new string[8];  //2
            dataText[i++] = new string[7];  //3
            dataText[i++] = new string[30];  //4
            dataText[i++] = new string[14]; //5
            dataText[i++] = new string[12];  //6
            dataText[i++] = new string[12]; //7
            dataText[i++] = new string[11];  //8
            dataText[i++] = new string[8];  //9
            dataText[i++] = new string[12]; //10
            dataText[i++] = new string[27]; //11
            dataText[i] = new string[17];   //12
#if DEBUG
            Console.WriteLine($"Размер dataText[{i}]");
#endif
            return dataText;
        }

        private static string[][] CreateVariables(string[][] dataText)
        {
            dataText = TextVariables.VariablesText(dataText);
            dataText = TextVariables.VariablesTextAnswers(dataText);
            return dataText;
        }
        private static string[][] CreateBranching(string[][] dataText)
        {
            dataText = TextBranching.BranchingText(dataText);
            dataText = TextBranching.BranchingTextAnswers(dataText);
            return dataText;
        }
        private static string[][] CreateCycles(string[][] dataText)
        {
            dataText = TextCycles.CyclesText(dataText);
            dataText = TextCycles.CyclesTextAnswers(dataText);
            return dataText;
        }
        private static string[][] CreateArraySingle(string[][] dataText)
        {
            dataText = TextArraySingle.ArraySingleText(dataText);
            dataText = TextArraySingle.ArraySingleTextAnswers(dataText);
            return dataText;
        }
        private static string[][] CreateArrayTwoDimensional(string[][] dataText)
        {
            dataText = TextArrayTwoDimensional.ArrayTwoDimensionalText(dataText);
            dataText = TextArrayTwoDimensional.ArrayTwoDimensionalTextAnswers(dataText);
            return dataText;
        }
        private static string[][] CreateNumbersInWords(string[][] dataText)
        {
            dataText = NumbersInWords.WordsNumbers(dataText);
            return dataText;
        }
        private static string[][] CreatePhrasesCommon(string[][] dataText)
        {
            dataText = CommonPhrases.PhrasesCommon(dataText);
            return dataText;
        }
    }
}
