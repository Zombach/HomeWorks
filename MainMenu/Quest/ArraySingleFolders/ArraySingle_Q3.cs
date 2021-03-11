namespace MainMenu.Quest.ArraySingleFolders
{
    public static class ArraySingle_Q3
    {
        public static double[] Quest(int[] ints)
        {
            double[] tmp = new double[1];
            int tmp2 = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < tmp2)
                {
                    tmp2 = ints[i];
                    tmp[0] = i;
                }
            }
            return tmp;
        }
    }
}
