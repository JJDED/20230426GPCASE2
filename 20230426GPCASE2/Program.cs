using _20230426GPCASE2;
using _20230426GPCASE2.Data;
using _20230426GPCASE2.Model;

public class Program
{
    private static TecData tecData = new TecData();
    public static void Main(string[] args)
    {   
        var subjectData = tecData.PopulateSubject(TecData.Subjects, TecData.Teachers, TecData.Students);        
        Console.WriteLine("Hej velkommen til TEC HF1!");
        while ()
        {
            Console.WriteLine("Hvad vil du søge på?");
            Console.WriteLine("Lærer, Elev eller Fag: ");
            var answer = Console.ReadLine()?.ToLower();

            if ((string.IsNullOrEmpty(answer) || !answer.Equals("lærer") && !answer.Equals("elev") && !answer.Equals("fag")))
            {
                Console.Clear();
                Console.WriteLine($"Inputtet var forkert, du kan ikke søge efter {answer}. Genstarter programmet.");
            }
            switch (answer)
            {
                case "lærer":
                    Console.WriteLine("Skriv lærerens fulde navn: ");
                    var teacherName = Console.ReadLine()?.ToLower();
                    var teacherSubject = subjectData.Where(x => x.Teacher.FullName.ToLower().Equals(teacherName)).ToList();
                    Console.WriteLine($"Lærerens navn: \n{teacherSubject.Select(x => x.Teacher.FullName).First()} \n");
                    foreach (var subject in teacherSubject)
                    {
                        Console.WriteLine($"Underviser i: \n{subject.SubjectName} \n");
                        Console.WriteLine($"Elever i {subject.SubjectName}: \n{string.Join("\n", subject.Students.Select(x => x.FullName))}\n");
                    }
                    break;
                case "elev":
                    Console.WriteLine("Skriv elevens fulde navn: ");
                    var studentName = Console.ReadLine()?.ToLower();
                    var studentSubject = string.Join(subjectData.Where(x => x.Students.FullName.ToLower().Equals(studentName)).ToList());
                    Console.WriteLine($"Elevens navn: \n{studentSubject.Select(x => x.Students.FullName).First()})\n");
                    foreach (var subject in studentSubject)
                    {
                        Console.WriteLine($"Har disse fag: \n{subject.SubjectName}\n");
                        Console.WriteLine($"Underviser i {subject.SubjectName}: \n{string.Join("\n" subject.Teacher.Select(x => x.FullName))}\n");
                    }                                        
                    break;
                case "fag":
                    Console.WriteLine("Skriv fagets fulde navn: ");
                    var subjectName = Console.ReadLine()?.ToLower();                    
                    foreach (var subject in subjectData)
                    {
                        Console.WriteLine($"Fag: \n {subject.SubjectName} \n");
                        Console.WriteLine($"Underviser i {subject.SubjectName}: \n");
                        Console.WriteLine($"Elever i {subject.SubjectName}: \n");
                    }                    
                    break;
            }
        }
        
        
    }
}

