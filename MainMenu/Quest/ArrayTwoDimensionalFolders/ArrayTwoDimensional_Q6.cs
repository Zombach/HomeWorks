namespace MainMenu.Quest.ArrayTwoDimensionalFolders
{
    public static class ArrayTwoDimensional_Q6
    {
        public static double[] Quest(int[,] ints)
        {
            double[] tmp = new double[ints.GetLength(0) * ints.GetLength(1) + 1];
            int[,] temp = new int[ints.GetLength(1), ints.GetLength(0)];
            for (int i = 0; i < ints.GetLength(1); i++)
            {
                for (int j = 0; j < ints.GetLength(0); j++)
                {
                    temp[i, j] = ints[j, i];
                }
            }
            int count = 0;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    tmp[count++] = ints[i, j];
                }
            }
            tmp[tmp.Length - 1] = ints.GetLength(0);
            return tmp;
        }
    }
}