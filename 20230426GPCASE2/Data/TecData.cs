using _20230426GPCASE2.Model;

namespace _20230426GPCASE2.Data;

public class TecData
{
    public static List<Teacher> Teachers = new List<Teacher>
    {
        new Teacher { FullName = "Niels Elsborg Olesen"},
        new Teacher { FullName = "Flemming Sørensen"},
        new Teacher { FullName = "Henrik Vincents Poulsen" },
        new Teacher { FullName = "Peter Suni Lindenskov" }
    };

    public static List<Student> Students = new List<Student>
    {
        new Student { FullName = "Alexander Mathias Thamdrup"},
        new Student { FullName = "Allan Gawron"},
        new Student { FullName = "Andreas Carl Balle" },
        new Student { FullName = "Darab Haqnazar" },
        new Student { FullName = "Felix Enok Berger", HasStudieTeknik = false },
        new Student { FullName = "Jamie Jamahl de la Sencerie El-Dessouky", HasStudieTeknik = false },
        new Student { FullName = "Jeppe Carlseng Pedersen" },
        new Student { FullName = "Joseph Holland-Hale" },
        new Student { FullName = "Kamil Marcin Kulpa", HasStudieTeknik = false },
        new Student { FullName = "Loke Emil Bendtsen" },
        new Student { FullName = "Mark Hyrsting Larsen", HasStudieTeknik = false },
        new Student { FullName = "Niklas Kim Jensen" },
        new Student { FullName = "Rasmus Peter Hjort" },
        new Student { FullName = "Sammy Damiri", HasStudieTeknik = false },
        new Student { FullName = "Thomas Mose Holmberg" },
        new Student { FullName = "Tobias Casanar Besser" }
    };

    public static List<Subject> Subjects = new List<Subject>
    {
        new Subject { SubjectName = "Studieteknik"},
        new Subject { SubjectName = "Grundlæggende Programmering"},
        new Subject { SubjectName = "Database Programmering"},
        new Subject { SubjectName = "Objektorienteret Programmering"},
        new Subject { SubjectName = "Computerteknologi"},
        new Subject { SubjectName = "Clientside Programmering"},
        new Subject { SubjectName = "Netværk"}
    };

    public List<Subject> PopulateSubject(List<Subject> subjects, List<Teacher> teachers, List<Student> students)
    {
        var subjectList = new List<Subject>();
        foreach (var subject in subjects)
        {
            var sub = new Subject();            
            switch (subject.SubjectName)
            {
                case "Studieteknik":
                    sub.Teacher = teachers.First(x => x.FullName.Equals("Niels Elsborg Olesen"));
                    sub.SubjectName = subject.SubjectName;
                    sub.Students = students.Where(x => x.HasStudieTeknik == true).ToList();
                    break;
                case "Grundlæggende Programmering":
                    sub.SubjectName = subject.SubjectName;
                    sub.Teacher = teachers.First(x => x.FullName.Equals("Niels Elsborg Olesen"));
                    sub.Students = students;
                    break;
                case "Database Programmering":
                    sub.SubjectName = subject.SubjectName;
                    sub.Teacher = teachers.First(x => x.FullName.Equals("Niels Elsborg Olesen"));
                    sub.Students = students;
                    break;
                case "Objektorienteret Programmering":
                    sub.SubjectName = subject.SubjectName;
                    sub.Teacher = teachers.First(x => x.FullName.Equals("Flemming Sørensen"));
                    sub.Students = students;
                    break;
                case "Computerteknologi":
                    sub.SubjectName = subject.SubjectName;
                    sub.Teacher = teachers.First(x => x.FullName.Equals("Niels Elsborg Olesen"));
                    sub.Students = students;
                    break;
                case "Clientside Programmering":
                    sub.SubjectName = subject.SubjectName;
                    sub.Teacher = teachers.First(x => x.FullName.Equals("Peter Suni Lindenskov"));
                    sub.Students = students;
                    break;
                case "Netværk":
                    sub.SubjectName = subject.SubjectName;
                    sub.Teacher = teachers.First(x => x.FullName.Equals("Henrik Vincents Poulsen"));
                    sub.Students = students;
                    break;
            }

            subjectList.Add(sub);

        }

        return subjectList;
    }
}
