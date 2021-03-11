namespace MainMenu.Quest.ArraySingleFolders
{
    public static class ArraySingle_Q9
    {
        public static double[] Quest(int[] ints)
        {
            double[] tmp = new double[ints.Length];
            int tmp2 = 0;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                tmp2 = ints[i];
                for (int j = 1 + i; j < ints.Length; j++)
                {
                    if (ints[i] > ints[j])
                    {
                        tmp2 = ints[i];
                        ints[i] = ints[j];
                        ints[j] = tmp2;
                    }
                }
            }
            tmp.CopyTo(ints, 0);
            return tmp;
        }
    }
}
