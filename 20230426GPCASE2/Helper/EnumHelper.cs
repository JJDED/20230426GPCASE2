using _20230426GPCASE2.Model.Enum;

namespace _20230426GPCASE2.Helper
{
    public class EnumHelper
    {
        public Search? GetEnum(string input)
        {
            if (input!.Equals("lærer")) return Search.Teacher;
            if (input!.Equals("elev")) return Search.Student;
            if (input!.Equals("fag")) return Search.Subject;
            return null;
        }
    }
}
