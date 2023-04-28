using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static _20230426GPCASE2.Codes.Utility;

namespace _20230426GPCASE2.Codes;

internal class H1
{
    public Person[] Student { get; set; }

    public Person[] Teacher { get; set; }

    public Subjects[] Subject { get; set; }

    public H1()
    {
        Student = new Person[]
        {
            new Person() { FirstName = "Alexander Mathias", LastName = "Thamdrup"},
            new Person() { FirstName = "Allan", LastName = "Gawron"},
            new Person() { FirstName = "Andreas Carl", LastName = "Balle"},
            new Person() { FirstName = "Darab", LastName = "Haqnazar"},
            new Person() { FirstName = "Felix Enok", LastName = "Berger"},
            new Person() { FirstName = "Jamie Jamahl", LastName = "de la Sencerie El-Dessouky"},
            new Person() { FirstName = "Jeppe Carlseng", LastName = "Pedersen"},
            new Person() { FirstName = "Joseph", LastName = "Holland-Hale"},
            new Person() { FirstName = "Kamil Marcin", LastName = "Kulpa"},
            new Person() { FirstName = "Loke Emil", LastName = "Bendtsen"},
            new Person() { FirstName = "Mark Hyrsting", LastName = "Larsen"},
            new Person() { FirstName = "Niklas Kim", LastName = "Jensen"},
            new Person() { FirstName = "Rasmus Peter", LastName = "Hjort"},
            new Person() { FirstName = "Sammy", LastName = "Damiri"},
            new Person() { FirstName = "Thomas Mose", LastName = "Holmberg"},
            new Person() { FirstName = "Tobias Casanar", LastName = "Besser"}            
        };

        Teacher = new Person[]
        {
            new Person() { FirstName = "Niels Elsborg", LastName = "Olsen"},
            new Person() { FirstName = "Flemming", LastName = ""},
            new Person() { FirstName = "Henrik", LastName = ""},
            new Person() { FirstName = "Peter", LastName = ""}            
        };

        Subject = new Subjects[]
        {
            new Subjects() { Subject = "Studieteknik"},
            new Subjects() { Subject = "Grundlæggende Programmering"},
            new Subjects() { Subject = "Database Programmering"},
            new Subjects() { Subject = "Objektorienteret Programmering"},
            new Subjects() { Subject = "Computerteknologi"},
            new Subjects() { Subject = "Clientside Programmering"},
            new Subjects() { Subject = "Netværk"}
        };
    }
}
