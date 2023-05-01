using _20230426GPCASE2.Data;
using _20230426GPCASE2.Helper;
using _20230426GPCASE2.Model.Enum;

public class Program
{
    private static TecData tecData = new TecData();
    private static EnumHelper enumHelper = new EnumHelper();
    public static void Main()
    {
        bool programRunning = true;
        var subjectData = tecData.PopulateSubject(TecData.Subjects, TecData.Teachers, TecData.Students);
        Console.WriteLine("Hej velkommen til TEC HF1!");
        do
        {
            Console.WriteLine("Hvad vil du søge på?");
            Console.WriteLine("Lærer, Elev eller Fag: ");
            var answer = Console.ReadLine()?.ToLower();

            if ((string.IsNullOrEmpty(answer) || !answer.Equals("lærer") && !answer.Equals("elev") && !answer.Equals("fag")))
            {
                Console.Clear();
                Console.WriteLine($"Inputtet var forkert, du kan ikke søge efter {answer}. Genstarter programmet.");
                Main();
            }

            var search = enumHelper.GetEnum(answer!);
            switch (search)
            {
                case Search.Teacher:
                    Console.WriteLine("Skriv lærerens fulde navn: ");
                    var teacherName = Console.ReadLine()?.ToLower();
                    if (string.IsNullOrEmpty(teacherName))
                    {
                        Console.Clear();
                        Console.WriteLine($"Forkert input. Kører programmet forfra. \n");
                        Main();
                    }
                    var teacherSubject = subjectData.Where(x => x.Teacher.FullName.ToLower().Equals(teacherName)).ToList();
                    Console.Clear();
                    Console.WriteLine($"Lærerens navn: \n{teacherSubject.Select(x => x.Teacher.FullName).First()} \n");
                    foreach (var subject in teacherSubject)
                    {
                        Console.WriteLine($"Underviser i: \n{subject.SubjectName} \n");
                        Console.WriteLine($"Elever i {subject.SubjectName}: \n{string.Join("\n", subject.Students.Select(x => x.FullName))}\n");
                    }
                    break;

                case Search.Student:
                    Console.WriteLine("Skriv elevens fulde navn: ");
                    var studentName = Console.ReadLine()?.ToLower();
                    if (string.IsNullOrEmpty(studentName))
                    {
                        Console.Clear();
                        Console.WriteLine($"Forkert input. Kører programmet forfra. \n");
                        Main();
                    }
                    var studentSubject = subjectData.Where(x => x.Students.Any(y => y.FullName.ToLower().Equals(studentName))).ToList(); ;
                    Console.Clear();
                    Console.WriteLine($"Elevens navn: \n{TecData.Students.First(x => x.FullName.ToLower().Equals(studentName)).FullName}\n");
                    foreach (var subject in studentSubject)
                    {
                        Console.WriteLine($"Har [{subject.SubjectName}] med underviser [{subject.Teacher.FullName}]");
                    }
                    break;

                case Search.Subject:
                    Console.WriteLine("Skriv fagets fulde navn: ");
                    var subjectName = Console.ReadLine()?.ToLower();
                    if (string.IsNullOrEmpty(subjectName))
                    {
                        Console.Clear();
                        Console.WriteLine($"Forkert input. Kører programmet forfra. \n");
                        Main();
                    }
                    var filteredSubject = subjectData.First(x => x.SubjectName.ToLower().Equals(subjectName));
                    Console.Clear();
                    Console.WriteLine($"Fag: \n{filteredSubject.SubjectName} med underviser [{filteredSubject.Teacher.FullName}]\n");
                    Console.WriteLine($"Elever i {filteredSubject.SubjectName}: \n{string.Join("\n", filteredSubject.Students.Select(x => x.FullName))}\n");
                    break;
            }

            Console.WriteLine("\nVil du søge efter mere? Y/N");
            var query = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(query) || !query.Equals("y") && !query.Equals("n"))
            {
                Console.Clear();
                Console.WriteLine($"Forkert input. Kører programmet forfra. \n");
                Main();
            }

            if (query!.Equals("y"))
            {
                Console.Clear();
                programRunning = true;
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Du har valgt at lukke programmet.");
                programRunning = false;
            }
        }

        while (programRunning);
    }
}

