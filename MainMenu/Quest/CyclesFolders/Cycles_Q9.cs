namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q9
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //string str;
            //int count = 0;
            //Console.Write("Введите число = ");
            //str = Console.ReadLine();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] % 2 != 0)
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //Console.WriteLine("Колличество нечетных цифр = " + count);
            //Console.WriteLine();
        }
    }
}
