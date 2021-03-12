namespace MainMenu.Quest.ArrayTwoDimensionalFolders
{
    public static class ArrayTwoDimensional_Q5
    {
        public static double[] Quest(int[,] ints)
        {
            double[] tmp = new double[1];
            tmp[0] = 0;
            for(int i = 0; i < ints.GetLength(0); i++)
            {
                for(int j = 0; j < ints.GetLength(1); j++)
                {
                    int a = i - 1;
                    int b = j + 1;
                    int c = i + 1;
                    int d = j - 1;

                    if ((a < 0 || ints[i, j] > ints[i - 1, j])
                        && (b >= ints.GetLength(1) || ints[i, j] > ints[i, j + 1])
                        && (c >= ints.GetLength(0) || ints[i, j] > ints[i + 1, j])
                        && (d < 0 || ints[i, j] > ints[i, j - 1]))
                    {
                        tmp[0]++;
                    }
                }
            }
            return tmp;
        }
    }
}