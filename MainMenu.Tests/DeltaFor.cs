using NUnit.Framework;

namespace MainMenu.Tests
{
    public class DeltaFor
    {
        public static void Delta(double[] expected, double[] actual)
        {
            double delta = 0.5d;
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], delta);
            }
        }
    }
}
