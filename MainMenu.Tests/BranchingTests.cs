using NUnit.Framework;
using MainMenu.Text;
using MainMenu.Quest;

namespace MainMenu.Tests
{
    public class BranchingTests
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
            actual = Branching.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 11, 22 }, new double[] { 24 })]
        [TestCase(new int[] { 21, 42 }, new double[] { 49 })]
        [TestCase(new int[] { 1, 23 }, new double[] { 89 })]
        public void Quest_2(int[] Number, double[] expected)
        {
            programClass.dataTextY = 2;
            programClass.dataQueriesClass.number_1 = Number[0];
            programClass.dataQueriesClass.number_2 = Number[1];
            double[] actual = new double[1];
            actual = Branching.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 11, 22 }, new double[] { 24 })]
        [TestCase(new int[] { 21, 42 }, new double[] { 49 })]
        [TestCase(new int[] { 1, 23 }, new double[] { 89 })]
        public void Quest_3(int[] Number, double[] expected)
        {
            programClass.dataTextY = 3;
            programClass.dataQueriesClass.number_1 = Number[0];
            programClass.dataQueriesClass.number_2 = Number[1];
            double[] actual = new double[1];
            actual = Branching.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 11, 22 }, new double[] { 24 })]
        [TestCase(new int[] { 21, 42 }, new double[] { 49 })]
        [TestCase(new int[] { 1, 23 }, new double[] { 89 })]
        public void Quest_4(int[] Number, double[] expected)
        {
            programClass.dataTextY = 4;
            programClass.dataQueriesClass.number_1 = Number[0];
            programClass.dataQueriesClass.number_2 = Number[1];
            double[] actual = new double[1];
            actual = Branching.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 11, 22 }, new double[] { 24 })]
        [TestCase(new int[] { 21, 42 }, new double[] { 49 })]
        [TestCase(new int[] { 1, 23 }, new double[] { 89 })]
        public void Quest_5(int[] Number, double[] expected)
        {
            programClass.dataTextY = 5;
            programClass.dataQueriesClass.number_1 = Number[0];
            programClass.dataQueriesClass.number_2 = Number[1];
            double[] actual = new double[1];
            actual = Branching.QuestAll(programClass);
            Assert.AreEqual(expected, actual);
        }
    }
}
