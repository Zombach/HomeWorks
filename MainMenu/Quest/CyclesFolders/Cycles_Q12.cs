namespace MainMenu.Quest.CyclesFolder
{
    public static class Cycles_Q12
    {
        public static double[] Quest(ProgramClass programClass)
        {
            double[] tmp = new double[1];
            tmp[0] = (5 * programClass.dataQueriesClass.number_1 + programClass.dataQueriesClass.number_2 * programClass.dataQueriesClass.number_2) /
                (programClass.dataQueriesClass.number_2 - programClass.dataQueriesClass.number_1);
            return tmp;
            //string strX;
            //string strY;
            //Console.Write("Введите первую строку: ");
            //strX = Console.ReadLine();
            //Console.Write("Введите второе строку: ");
            //strY = Console.ReadLine();
            //int x;
            //Console.Write("Использовать для сравнения только цифры? Введите 1 если да, и 0 если нет = ");
            //do
            //{
            //    x = Convert.ToInt32(Console.ReadLine());
            //    if (x == 0 || x == 1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Нужно указать '1' либо '0' = ");
            //    Console.Write("Использовать для сравнения только цифры? Введите 1 если да, и 0 если нет = ");
            //}
            //while (true);

            //if (x == 1)
            //{
            //    Regex regex = new Regex(@"\D");
            //    strX = regex.Replace(strX, "");
            //    strY = regex.Replace(strY, "");
            //}

            //bool bo = false;
            //for (int i = 0; i < strX.Length; i++)
            //{
            //    for (int j = 0; j < strY.Length; j++)
            //    {
            //        if (strX[i] == strY[j])
            //        {
            //            bo = true;
            //            break;
            //        }
            //    }
            //}

            //if (bo)
            //{
            //    Console.WriteLine("ДА");
            //}
            //else
            //{
            //    Console.WriteLine("НЕТ");
            //}
            //Console.WriteLine();
        }
    }
}
