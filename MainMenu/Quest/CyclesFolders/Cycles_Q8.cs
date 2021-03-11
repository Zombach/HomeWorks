namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q8
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //Double x;
            //Double n;
            //int w;
            //do
            //{
            //    Console.Write("Введите целое число, у которого есть целый кубический корень: ");
            //    x = Convert.ToDouble(Console.ReadLine());
            //    n = Math.Round(Math.Pow(x, 1 / 3d));
            //    w = (int)n;
            //    if (Math.Pow(n, 3) == x && w == n)
            //    {
            //        break;
            //    }
            //}
            //while (true);

            //Double tmp = x;
            //Double tmp2 = 1;
            //Double temp = 0;

            //for (int i = 0; i < x; i--)
            //{
            //    temp = tmp;
            //    tmp = (tmp + tmp2) / 2;
            //    if (tmp > n)
            //    {
            //        continue;
            //    }
            //    else if (tmp < n)
            //    {
            //        tmp2 = tmp;
            //        tmp = temp;

            //    }
            //    else
            //    {
            //        Console.WriteLine(tmp);
            //        break;
            //    }
            //}
            //Console.WriteLine();
        }
    }
}
