using MainMenu.Text;
using MainMenu.Quest;
using NUnit.Framework;

namespace MainMenu.Tests
{
    public class VariablesTests
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
        public void Quest_1(int[] Number, double[] expected)
        {
            programClass.dataTextY = 1;
            programClass.dataQueriesClass.number_1 = Number[0];
            programClass.dataQueriesClass.number_2 = Number[1];
            double[] actual = new double[1];
            actual = Variables.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 12, 42 }, new double[] { 42 })]
        [TestCase(new int[] { 33, 4 }, new double[] { 4 })]
        [TestCase(new int[] { 56, 7 }, new double[] { 7 })]
        public void Quest_2(int[] Number, double[] expected)
        {
            programClass.dataTextY =2 ;
            programClass.dataQueriesClass.number_1 = Number[0];
            programClass.dataQueriesClass.number_2 = Number[1];
            double[] actual = new double[2];
            actual = Variables.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 52, 72 }, new double[] { 49 })]
        [TestCase(new int[] { 13, 26 }, new double[] { 49 })]
        [TestCase(new int[] { 24, 52 }, new double[] { 49 })]
        public void Quest_3(int[] Number, double[] expected)
        {
            programClass.dataTextY = 3;
            programClass.dataQueriesClass.number_1 = Number[0];
            programClass.dataQueriesClass.number_2 = Number[1];
            double[] actual = new double[2];
            actual = Variables.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 24, 52, 44 }, new double[] { 0 })]
        [TestCase(new int[] { 57, 25, 87 }, new double[] { 1 })]
        [TestCase(new int[] { 1, 5, 31 }, new double[] { 26 })]
        public void Quest_4(int[] Number, double[] expected)
        {
            programClass.dataTextY = 4;
            programClass.dataQueriesClass.number_1 = Number[0];
            programClass.dataQueriesClass.number_2 = Number[1];
            programClass.dataQueriesClass.number_3 = Number[2];
            double[] actual = new double[1];
            actual = Variables.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 141, 2, 95, 11 }, new double[] { 0, 11 })]
        [TestCase(new int[] { 21, 46, 1, 12 }, new double[] { 1, -34 })]
        [TestCase(new int[] { 51, 12, 41, 4 }, new double[] { 0, 4 })]
        public void Quest_5(int[] Number, double[] expected)
        {
            programClass.dataTextY = 5;
            programClass.dataQueriesClass.number_1 = Number[0];
            programClass.dataQueriesClass.number_2 = Number[1];
            programClass.dataQueriesClass.number_3 = Number[2];
            programClass.dataQueriesClass.number_4 = Number[3];
            double[] actual = new double[2];
            actual = Variables.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }
    }
}
