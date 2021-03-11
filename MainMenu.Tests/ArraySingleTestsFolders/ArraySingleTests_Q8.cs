using NUnit.Framework;
using MainMenu.Quest;
using MainMenu.Text;
using System;

namespace MainMenu.Tests.ArraySingleTestsFolders
{
 
    
    public class ArraySingle_Q1Tests
    {
        ProgramClass programClass = new ProgramClass()
        {
            section = 4,
            dataTextX = 4,
            dataQueriesClass = DataQueries.DataQueriesC(),
            dataTextClass = DataText.DataTextC()
        };

        [TestCase(new int[] { 11, 22 }, new double[] { 24 })]
        [TestCase(new int[] { 21, 42 }, new double[] { 49 })]
        [TestCase(new int[] { 1, 23 }, new double[] { 89 })]
        public void Quest(int[] Number, double[] expected)
        {
            programClass.dataTextY = 1;
            programClass.dataQueriesClass.number_1 = Number[0];
            programClass.dataQueriesClass.number_2 = Number[1];
            double[] actual = new double[1];
            actual = ArraySingle.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }        
    }
}
