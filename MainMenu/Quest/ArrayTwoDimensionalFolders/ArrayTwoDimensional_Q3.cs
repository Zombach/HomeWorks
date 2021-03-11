namespace MainMenu.Quest.ArrayTwoDimensionalFolders
{
    public static class ArrayTwoDimensional_Q3
    {
        public static double[] Quest(int[,] ints)
        {
            double[] tmp = new double[2];
            int temp = ints[0, 0];
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (temp > ints[i, j])
                    {
                        temp = ints[i, j];
                        tmp[0] = i;
                        tmp[1] = j;
                    }
                }
            }
            return tmp;
        }
    }
}