using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu.Tests.VariablesTestsFolders
{
    public class DeltaForVariable
    {
        public static void DeltaVariables(double[] actual, double[] expected)
        {
            double delta = 0.5d;
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], delta);
            }
        }
    }
}
