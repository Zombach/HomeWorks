using System;
using System.Collections.Generic;
using MainMenu.Text;
using System.Text.RegularExpressions;

namespace MainMenu
{
    public static class ConsoleInPut
    {
        public static int InPutInt()
        {
            string str;
            bool tmp;
            do
            {
                str = InPutConsole();
                str = InputReplace(str);
                tmp = InputValidationInt(str);                
            }
            while (!tmp);

            int x = ConvertToInt(str);
            return x;
        }
        public static double InPutDouble()
        {
            string str;
            str = InPutConsole();
            str = InputReplace(str);
            str = InputTrim(str);
            double x = ConvertToDouble(str);
            return x;
        }
        public static int InPutInForQuest(string[][] dataText, ProgramClass programClass)
        {
            int x = ConsoleInPut.InputAndHelp(dataText, programClass);
            return x;
        }
        private static string InPutConsole()
        {
            return Console.ReadLine();
        }
        private static string InputReplace(string str)
        {
            string tmp = "-";
            bool bo = false;
            if (str[0] == '-')
            {
                bo = true;
            }
            Regex regex = new Regex(@"\D");
            str = regex.Replace(str, string.Empty);
            if (bo == true)
            {
                str = tmp + str;
            }
            return str;
        }
        private static string InputTrim(string str)
        {
            if (str.Length> 100)
            {
                str = str.Substring(0,99);
            }
                return str;
        }
        private static bool InputValidationInt(string str)
        {
            bool check = true;
            if (str.Length == 0)
            {
                check = false;
                return check;
            }
            double d = Convert.ToDouble(str);
            if (d > int.MaxValue)
            {
                Console.WriteLine($"Превышение размеров инт - {str}");
                check = false;
                return check;
            }
            return check;
        }
        private static int ConvertToInt(string str)
        {
            int x = Convert.ToInt32(str);
            return x;
        }
        private static double ConvertToDouble(string str)
        {
            double x = Convert.ToDouble(str);
            return x;
        }
        private static int InPutXQuest(int x)
        {

            return x;
        }
        private static int InputAndHelp(string[][] dataText, ProgramClass programClass, string result = null)
        {
            Fill_In.DataOutputString(dataText, programClass);
            int x = ConsoleInPut.InPutInt();
            return x;
        }    
    }
    
}
