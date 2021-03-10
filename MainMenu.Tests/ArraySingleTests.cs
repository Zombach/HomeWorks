using NUnit.Framework;
using MainMenu.Quest;
using MainMenu.Text;
using System;

namespace MainMenu.Tests
{
 
    
    public class ArraySingleTests
    {
        ProgramClass programClass = new ProgramClass()
        {
            section = 4,
            dataTextX = 4,
            dataQueriesClass = DataQueries.DataQueriesC(),
            dataTextClass = DataText.DataTextC()
        };
        
        [Test]
        public void Quest_1_min_1()
        {
            programClass.dataTextY = 1;
            programClass.dataQueriesClass.number_1 = 33;
            programClass.dataQueriesClass.number_2 = 1;

            double[] actual = new double[1];
            double[] expected = { 34 };
                 
            actual = ArraySingle.QuestAll(programClass);            
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 11, 22 }, new double[] {33})]
        public void Quest_1_min(int[] Number, double[] expected)
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
