namespace MainMenu.Quest.ArraySingleFolders
{
    public static class ArraySingle_Q2
    {
        public static double[] Quest(int[] ints)
        {
            double[] tmp = new double[1];
            tmp[0] = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > tmp[0])
                {
                    tmp[0] = ints[i];
                }
            }
            return tmp;
        }
    }
}
