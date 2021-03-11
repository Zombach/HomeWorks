namespace MainMenu.Quest.ArraySingleFolders
{
    public static class ArraySingle_Q10
    {
        public static double[] Quest(int[] ints)
        {
            double[] tmp = new double[ints.Length];
            int tmp2 = 0;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] < ints[i + 1])
                {
                    tmp2 = ints[i];
                    ints[i] = ints[i + 1];
                    ints[i + 1] = tmp2;
                    for (int j = i; j > 0; j--)
                    {
                        if (j < 0)
                        {
                            break;
                        }
                        else if (ints[j - 1] < ints[j])
                        {
                            tmp2 = ints[j];
                            ints[j] = ints[j - 1];
                            ints[j - 1] = tmp2;
                        }
                        else break;
                    }
                }
            }
            tmp.CopyTo(ints, 0);
            return tmp;
        }
    }
}
