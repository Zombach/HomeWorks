namespace MainMenu.Quest.ArraySingleFolders
{
    public static class ArraySingle_Q5
    {
        public static double[] Quest(int[] ints)
        {
            double[] tmp = new double[1];
            for (int i = 0; i < ints.Length; i++)
            {
                if (i % 2 != 0)
                {
                    tmp[0] += ints[i];
                }
            }
            return tmp;
        }
    }
}
