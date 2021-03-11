using MainMenu.Text;

namespace MainMenu.Tests.VariablesTestsFolders
{
    
    public class GetMockVariablesTests
    {
        public static ProgramClass GetStareMock()
        {
            ProgramClass programClass = new ProgramClass()
            {
                dataQueriesClass = DataQueries.DataQueriesC(),
                dataTextClass = DataText.DataTextC(),
                section = 1,
                dataTextX = 1
            };
            return programClass;
        }
        
        public static ProgramClass GetMock(int number)
        {
            ProgramClass programClass = GetStareMock();
            switch (number)
            {
                case 1:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 2:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 3:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 4:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 5:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 6:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 7:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 8:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 9:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 10:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 11:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 12:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 13:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 14:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 15:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 16:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 17:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 18:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 19:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                case 20:
                    WriteValue(programClass, new int[] { 1, 2, 3, 4 });
                    break;
                default:
                    break;
            }
            return programClass;
        }

        public static void WriteValue(ProgramClass programClass, int[] value)
        {
            programClass.dataQueriesClass.number_1 = value[0];
            programClass.dataQueriesClass.number_2 = value[1];
            programClass.dataQueriesClass.number_3 = value[2];
            programClass.dataQueriesClass.number_4 = value[3];
        }
    }
}
