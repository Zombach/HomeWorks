namespace MainMenu.Quest.ArrayTwoDimensionalFolders
{
    public static class ArrayTwoDimensional_Q1
    {
        public static double[] Quest(int[,] ints)
        {
            double[] tmp = new double[1];
            tmp[0] = ints[0, 0];
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (tmp[0] > ints[i, j])
                    {
                        tmp[0] = ints[i, j];
                    }
                }
            }
            return tmp;
        }
    }
}