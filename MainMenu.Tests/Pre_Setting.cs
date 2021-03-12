using MainMenu.Text;

namespace MainMenu.Tests
{
    public class Pre_Setting
    {
        public static ProgramClass GetStartSettingMock()
        {
            ProgramClass programClass = new ProgramClass()
            {
                dataQueriesClass = DataQueries.DataQueriesC(),
                dataTextClass = DataText.DataTextC()
            };
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
