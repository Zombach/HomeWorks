using MainMenu.Text;

namespace MainMenu.Tests.CyclesTestsFolders
{
    public class GetMockCyclesTests
    {
        public static ProgramClass GetMock(int number)
        {
            ProgramClass programClass = Pre_Setting.GetStartSettingMock();
            programClass.dataTextX = 3;
            programClass.section = 3;
            int[] tmp = null;
            switch (number)
            {
                case 1:
                    tmp = new int [] { 1, 2, 3, 4 };
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
                    tmp = new int[] { 1, 22, 3, 4 };
                    break;
                case 6:
                    tmp = new int[] { 1, 222, 3, 4 };
                    break;
                case 7:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 8:
                    tmp = new int[] { 1, 1, 3, 4 };
                    break;
                case 9:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 10:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 11:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 12:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 13:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 14:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 15:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 16:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 17:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 18:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 19:
                    tmp = new int[] { 1, 2, 3, 4 };
                    break;
                case 20:
                    tmp = new int[] { 1, 2, 3, 4 };
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
