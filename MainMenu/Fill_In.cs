using System;
using System.Collections.Generic;
using MainMenu.Text;

namespace MainMenu
{
    public static class Fill_In
    {
        public static void DataOutputBlock(string[][] dataText, ProgramClass programClass)
        {
            for (int i = 0; i < dataText[programClass.dataTextX].Length; i++)
            {
                if (i == dataText[programClass.dataTextX].Length - 1)
                {
                    Console.Write(dataText[programClass.dataTextX][i]);
                    break;
                }
                Console.WriteLine(dataText[programClass.dataTextX][i]);
            }
        }

        public static void DataOutputString(string[][] dataText, ProgramClass programClass, string result = null)
        {
            if (result == null)
            {
                Console.Write("\n" + dataText[programClass.dataTextClass.comPhrase][programClass.dataTextClass.comPhraseString]);
            }
            else
            {
                Console.Write("\n" + dataText[programClass.dataTextClass.answer][programClass.dataTextClass.answerString] + result);
                Console.Write("\n\n\n");
            }
        }

        public static void StringOut(string[][] dataText, ProgramClass programClass)
        {
            Console.Write("\n" + dataText[programClass.dataTextClass.answer][programClass.dataTextClass.answerString]);
            Console.Write("\n\n\n");
            
        }

        public static void OutputString(string[][] dataText, ProgramClass programClass)
        {
            Console.Write("\n\n\n");
            Console.Write("\n" + dataText[programClass.dataTextClass.section][programClass.dataTextClass.quest]);
        }

        public static void OutputTmpString(string[][] dataText, string[] tmp, string[,] tmp2 = null)
        {
            for (int i = 0; i < tmp.Length; i++)
            {

            }
        }

        public static void OutputTmpString(string[][] dataText, string[,] tmp = null)
        {
            Console.Write("\n" + dataText[Program.dataTextClass.comPhrase][16] + " :");
            for (int i = 0; i < tmp.GetLength(0); i++)
            {
                for (int j = 0; j < tmp.GetLength(1); j++)
                {

                }
            }
        }
    }
}
