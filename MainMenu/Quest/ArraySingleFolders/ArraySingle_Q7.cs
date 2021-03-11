namespace MainMenu.Quest.ArraySingleFolders
{
    public static class ArraySingle_Q7
    {
        public static double[] Quest(int[] ints)
        {
            double[] tmp = new double[1];
            tmp[0] = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 != 0)
                {
                    tmp[0]++;
                }
            }
            return tmp;
        }
    }
}
