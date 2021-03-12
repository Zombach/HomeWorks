namespace MainMenu.Quest.ArrayTwoDimensionalFolders
{
    public static class ArrayTwoDimensional_Q6
    {
        public static int[,] Quest(int[,] ints)
        {
            int[,] tmp = new int[ints.GetLength(1), ints.GetLength(0)];
            for (int i = 0; i < ints.GetLength(1); i++)
            {
                for (int j = 0; j < ints.GetLength(0); j++)
                {
                    tmp[i, j] = ints[j, i];
                }
            }
            return tmp;
        }
    }
}