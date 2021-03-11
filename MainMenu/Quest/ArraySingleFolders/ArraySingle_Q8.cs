namespace MainMenu.Quest.ArraySingleFolders
{
    public static class ArraySingle_Q8
    {
        public static double[] Quest(int[] ints)
        {
            double[] tmp = new double[ints.Length];
            int tmp3 = 0;
            if (ints.Length % 2 != 0)
            {
                tmp3 = 1;
            }
            int tmp2 = ints.Length / 2;
            for (int i = 0; i < tmp2; i++)
            {
                tmp[i] = ints[tmp2 + tmp3 + i];
                tmp[tmp2 + tmp3 + i] = ints[i];
            }
            return tmp;
        }
    }
}
