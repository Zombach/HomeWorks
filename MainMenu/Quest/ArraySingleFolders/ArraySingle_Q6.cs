using System;

namespace MainMenu.Quest.ArraySingleFolders
{
    public static class ArraySingle_Q6
    {
        public static double[] Quest(int[] ints)
        {
            double[] tmp = new double[ints.Length];
            for (int i = 0; i < ints.Length; i++)
            {
                    tmp[tmp.Length - 1 - i] = ints[i];
            }
            return tmp;
        }
    }
}
