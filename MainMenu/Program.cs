using MainMenu.Text;
using MainMenu.Quest;
using System;

namespace MainMenu
{
    public class ProgramClass
    {
        public int section = 0;
        public int dataTextX = 0;
        public int dataTextY = 0;
        public DataTextClass dataTextClass;
        public DataQueriesClass dataQueriesClass;
    }
    class Program
    {
        public static ProgramClass programClass = new ProgramClass();
        public static DataTextClass dataTextClass = new DataTextClass();
        public static DataQueriesClass dataQueriesClass = new DataQueriesClass();
        static string[][] dataText;
        public static ProgramClass ProgramC(ProgramClass programClass, int Section = 0, int dataTextX = 0, int dataTextY = 0)
        {
            programClass.section = Section;            
            programClass.dataTextX = dataTextX;            
            programClass.dataTextY = dataTextY;            
            return programClass;
        }
 
        public static ProgramClass PC_DT_Y(int dataTextY)
        {
            programClass.dataTextY = dataTextY;
            return programClass;
        }

        static void Main(string[] args)
        {   
            //ssss.Test();  //Нужно потестить с Максом
            programClass.dataTextClass = DataText.DataTextC();
            programClass.dataQueriesClass = DataQueries.DataQueriesC();
            dataText = Start(dataText);
            Fill_In.DataOutputBlock(dataText, programClass);

            int x = ConsoleInPut.InPutInt();
            programClass = ProgramC(programClass, Section: x, dataTextX: x);
            programClass = SelectionQuest.SelectSection(programClass);
            Fill_In.DataOutputBlock(dataText, programClass);

            int y = ConsoleInPut.InPutInt();
            programClass = PC_DT_Y(y);
            programClass.dataTextClass = DataText.DTC_Section(programClass);
            programClass.dataTextClass = DataText.DTC_Quest(programClass);
            programClass.dataTextClass = DataText.DTC_AnswerString(programClass);
            Fill_In.OutputString(dataText, programClass);

            SelectionQuest.QuestStart(dataText, programClass);
        }


        private static string[][] Start(string[][] dataText)
        {
            dataText = DataText.CreateData(dataText);
            return dataText;
        }
    }
}
