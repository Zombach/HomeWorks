namespace MainMenu.Tests.VariablesTestsFolders
{
    public class GetMockVariablesTests
    {
        public static double[] GetExpectedMock_Q1(int number)
        {
            double[] expectedMock = null;
            switch (number)
            {
                case 1:
                    expectedMock = new double[] { 9 };
                    break;
                case 2:
                    expectedMock = new double[] { 9 };
                    break;
                case 3:
                    expectedMock = new double[] { -12 };
                    break;
                case 4:
                    expectedMock = new double[] { -9 };
                    break;
                case 5:
                    expectedMock = new double[] { -22 };
                    break;
                default:
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
                    expectedMock = new double[] { 2, 1 };
                    break;
                case 2:
                    expectedMock = new double[] { 2, 2 };
                    break;
                case 3:
                    expectedMock = new double[] { 2, 4 };
                    break;
                case 4:
                    expectedMock = new double[] { 44, 544 };
                    break;
                case 5:
                    expectedMock = new double[] { -22, -1 };
                    break;
                default:
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
                    expectedMock = new double[] { 0, 1 };
                    break;
                case 2:
                    expectedMock = new double[] { 1, 0 };
                    break;
                case 3:
                    expectedMock = new double[] { 2, 0 };
                    break;
                case 4:
                    expectedMock = new double[] { 12, 16 };
                    break;
                case 5:
                    expectedMock = new double[] { 0, -1 };
                    break;
                default:
                    break;
            }
            return expectedMock;
        }
        public static double[] GetExpectedMock_Q4(int number)
        {
            double[] expectedMock = null;
            switch (number)
            {
                case 1:
                    expectedMock = new double[] { 1 };
                    break;
                case 2:
                    expectedMock = new double[] { 0 };
                    break;
                case 3:
                    expectedMock = new double[] { 0 };
                    break;
                case 4:
                    expectedMock = new double[] { -2 };
                    break;
                case 5:
                    expectedMock = new double[] { -19 };
                    break;
                default:
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
                    expectedMock = new double[] { 1, 2 };
                    break;
                case 2:
                    expectedMock = new double[] { 0 };
                    break;
                case 3:
                    expectedMock = new double[] { -2, 8 };
                    break;
                case 4:
                    expectedMock = new double[] { 0, -4 };
                    break;
                case 5:
                    expectedMock = new double[] { -9, -202 };
                    break;
                default:
                    break;
            }
            return expectedMock;
        }
        public static ProgramClass GetMock(int number)
        {
            ProgramClass programClass = Pre_Setting.GetStartSettingMock();
            programClass.dataTextX = 1;
            programClass.section = 1;
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
                    tmp = new int[] { 4, 2, 3, 4 };
                    break;
                case 4:
                    tmp = new int[] { 544, 44, -883, -4 };
                    break;
                case 5:
                    tmp = new int[] { -1, -22, -3, -4 };
                    break;
                case 6:
                    tmp = new int[] { 0, 0, -3, -4 };
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
