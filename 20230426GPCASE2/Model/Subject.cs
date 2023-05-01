namespace _20230426GPCASE2.Model;

public class Subject
{
    public string SubjectName { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }
}
