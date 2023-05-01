using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static _20230426GPCASE2.Codes.Utility;

namespace _20230426GPCASE2.Codes;

internal class H1
{

    public static List<Teacher> Teachers = new List<Teacher>
    {
        new Teacher { FullName = "Niels Elsborg Olesen"},
        new Teacher { FullName = "Flemming"},
        new Teacher { FullName = "Henrik" },
        new Teacher { FullName = "Peter" }
    };

    public static List<Student> Student = new List<Student>
    {
        new Student { FullName = "Alexander Mathias Thamdrup"},
        new Student { FullName = "Allan Gawron"},
        new Student { FullName = "Andreas Carl Balle" },
        new Student { FullName = "Darab Haqnazar" },
        new Student { FullName = "Felix Enok Berger" },
        new Student { FullName = "Jamie Jamahl de la Sencerie El-Dessouky" },
        new Student { FullName = "Jeppe Carlseng Pedersen" },
        new Student { FullName = "Joseph Holland-Hale" },
        new Student { FullName = "Kamil Marcin Kulpa" },
        new Student { FullName = "Loke Emil Bendtsen" },
        new Student { FullName = "Mark Hyrsting Larsen" },
        new Student { FullName = "Niklas Kim Jensen" },
        new Student { FullName = "Rasmus Peter Hjort" },
        new Student { FullName = "Sammy Damiri" },
        new Student { FullName = "Thomas Mose Holmberg" },
        new Student { FullName = "Tobias Casanar Besser" }
    };


    public static List<Subject> Subject = new List<Subject>
    {
        new Subject { Subjects = "Studieteknik"},
        new Subject { Subjects = "Grundlæggende Programmering"},
        new Subject { Subjects = "Database Programmering"},
        new Subject { Subjects = "Objektorienteret Programmering"},
        new Subject { Subjects = "Computerteknologi"},
        new Subject { Subjects = "Clientside Programmering"},
        new Subject { Subjects = "Netværk"}
    };

    //public H1()
    //{
    //    new List<Teacher>
    //    {
    //        new Teacher { FullName = "Niels Elsborg Olesen"},
    //        new Teacher { FullName = "Flemming"},
    //        new Teacher { FullName = "Henrik"},
    //        new Teacher { FullName = "Peter"}

    //    };

    //     new List<Student>
    //    {
    //        new Student { FullName = "Alexander Mathias Thamdrup"},
    //        new Student { FullName = "Allan Gawron"},
    //        new Student { FullName = "Andreas Carl Balle"},
    //        new Student { FullName = "Darab Haqnazar"},
    //        new Student { FullName = "Felix Enok Berger"},
    //        new Student { FullName = "Jamie Jamahl de la Sencerie El-Dessouky"},
    //        new Student { FullName = "Jeppe Carlseng Pedersen"},
    //        new Student { FullName = "Joseph Holland-Hale"},
    //        new Student { FullName = "Kamil Marcin Kulpa"},
    //        new Student { FullName = "Loke Emil Bendtsen"},
    //        new Student { FullName = "Mark Hyrsting Larsen"},
    //        new Student { FullName = "Niklas Kim Jensen"},
    //        new Student { FullName = "Rasmus Peter Hjort"},
    //        new Student { FullName = "Sammy Damiri"},
    //        new Student { FullName = "Thomas Mose Holmberg"},
    //        new Student { FullName = "Tobias Casanar Besser"}            
    //    };
                
    //    new List<Subject>
    //    {
    //        new Subjects { Subject = "Studieteknik"},
    //        new Subjects { Subject = "Grundlæggende Programmering"},
    //        new Subjects { Subject = "Database Programmering"},
    //        new Subjects { Subject = "Objektorienteret Programmering"},
    //        new Subjects { Subject = "Computerteknologi"},
    //        new Subjects { Subject = "Clientside Programmering"},
    //        new Subjects { Subject = "Netværk"}
    //    };
    //}
}
