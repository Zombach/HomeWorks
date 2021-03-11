namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q10
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //string str;
            //int x;
            //Console.Write("Введите строку = ");
            //str = Console.ReadLine();
            //Console.Write("Использовать только цифры? Введите 1 если да, и 0 если нет = ");
            //do
            //{
            //    x = Convert.ToInt32(Console.ReadLine());
            //    if (x == 0 || x == 1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Нужно указать '1' либо '0' = ");
            //    Console.Write("Использовать только цифры? Введите 1 если да, и 0 если нет = ");
            //}
            //while (true);

            //string tmp = "";
            //if (x == 1)
            //{
            //    if (str[0] == Convert.ToChar("-"))
            //    {
            //        tmp = "-";
            //    }
            //    Regex regex = new Regex(@"\D");
            //    str = regex.Replace(str, "");
            //}

            //for (int i = 0; i < str.Length; i++)
            //{
            //    tmp += str[str.Length - 1 - i];
            //}
            //Console.WriteLine(tmp + "\n");
        }        
    }
}
