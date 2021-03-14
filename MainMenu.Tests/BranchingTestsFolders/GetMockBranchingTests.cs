using MainMenu.Text;

namespace MainMenu.Tests.BranchingTestsFolders
{
    public class GetMockBranchingTests
    {
        public static double[] GetExpectedMock_Q1(int number)
        {
            double[] expectedMock = null;
            switch (number)
            {
                case 1:
                    expectedMock = new double[] { -1 };
                    break;
                case 2:
                    expectedMock = new double[] { 4 };
                    break;
                case 3:
                    expectedMock = new double[] { -1 };
                    break;
                case 4:
                    expectedMock = new double[] { -1 };
                    break;
                case 5:
                    expectedMock = new double[] { -23 };
                    break;
                default:
                    expectedMock = null;
                    break;
            }
            return expectedMock;
        }
        public static double[] GetExpectedMock_Q2(int number)
        {
            double[] expectedMock = null;
            switch (number)
            {
                case 1:
                    expectedMock = new double[] { 1 };
                    break;
                case 2:
                    expectedMock = new double[] { 1 };
                    break;
                case 3:
                    expectedMock = new double[] { 1 };
                    break;
                case 4:
                    expectedMock = new double[] { 1 };
                    break;
                case 5:
                    expectedMock = new double[] { 3 };
                    break;
                default:
                    expectedMock = null;
                    break;
            }
            return expectedMock;
        }
        public static double[] GetExpectedMock_Q3(int number)
        {
            double[] expectedMock = null;
            switch (number)
            {
                case 1:
                    expectedMock = new double[] { 1, 2, 3 };
                    break;
                case 2:
                    expectedMock = new double[] { 2, 2, 2 };
                    break;
                case 3:
                    expectedMock = new double[] { 1, 2, 3 };
                    break;
                case 4:
                    expectedMock = new double[] { 3, 3, 4 };
                    break;
                case 5:
                    expectedMock = new double[] { -22, -3, -1 };
                    break;
                default:
                    expectedMock = null;
                    break;
            }
            return expectedMock;
        }
        public static double[] GetExpectedMock_Q4(int number)
        {
            double[] expectedMock = null;
            switch (number)
            {
                case 6:
                    expectedMock = new double[] { -2 };
                    break;
                case 7:
                    expectedMock = new double[] { -8 };
                    break;
                case 8:
                    expectedMock = new double[] { -4 };
                    break;
                default:
                    expectedMock = null;
                    break;
            }
            return expectedMock;
        }
        public static double[] GetExpectedMock_Q5(int number)
        {
            double[] expectedMock = null;
            switch (number)
            {
                case 1:
                    expectedMock = new double[] { 1, 0 };
                    break;
                case 2:
                    expectedMock = new double[] { 2, 0 };
                    break;
                case 3:
                    expectedMock = new double[] { 1, 0 };
                    break;
                case 4:
                    expectedMock = new double[] { 3, 0 };
                    break;
                case 5:
                    expectedMock = new double[] { -1, 0 };
                    break;                
                default:
                    expectedMock = null;
                    break;
            }
            return expectedMock;
        }
        public static ProgramClass GetMock(int number)
        {
            ProgramClass programClass = Pre_Setting.GetStartSettingMock();
            programClass.dataTextX = 2;
            programClass.section = 2;
            int[] tmp = null;
            switch (number)
            {
                case 1:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 2:
                    tmp = new int[] { 2, 2, 2, 2 };
                    break;
                case 3:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 4:
                    tmp = new int[] { 3, 4, 3, 4 };
                    break;
                case 5:
                    tmp = new int[] { -1, -22, -3, -4 };
                    break;
                case 6:
                    tmp = new int[] { 1, 8, 1, 0 };
                    break;
                case 7:
                    tmp = new int[] { 1, 22, 0, 0 };
                    break;
                case 8:
                    tmp = new int[] { 2, 18, 3, 0 };
                    break;
                default:
                    tmp = null;
                    break;
            }
            Pre_Setting.WriteValue(programClass, tmp);
            return programClass;
        }
    }
}
