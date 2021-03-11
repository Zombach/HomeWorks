namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q11
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //string str;
            // Console.Write("Введите число N ");
            // str = Console.ReadLine();
            // Double temp = Convert.ToDouble(str);

            // for (int i = 1; i < temp; i++)
            // {
            //     Double sumX = 0;
            //     Double sumY = 0;
            //     string tmp = i.ToString();
            //     for (int j = 0; j < tmp.Length; j++)
            //     {
            //         int g = Convert.ToInt32(tmp[j]);
            //         if (g % 2 == 0)
            //         {
            //             sumX += g;
            //         }
            //         else
            //         {
            //             sumY += g;
            //         }
            //     }
            //     if (sumX > sumY)
            //     {
            //         Console.Write(tmp + " ");
            //     }
            // }
            // Console.WriteLine();
        }
    }
}
