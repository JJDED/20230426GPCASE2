

using static _20230426GPCASE2.Codes.Utility;

SearchCriteria? Search()
{ 
    Console.WriteLine("Hej velkommen til TEC HF1!");
    Console.WriteLine("Hvad kunne du tænke dig at søge på?");
    Console.WriteLine("Lærer, Elev eller Fag: ");
    var answer = Console.ReadLine()?.ToLower();

    if (string.IsNullOrEmpty(answer) || !answer.Equals("lærer") && !answer.Equals("elev") && !answer.Equals("fag"))
    {
        Console.Clear();
        Console.WriteLine($"Inputtet var forkert, {answer} eksistere ikke. Genstarter programmet.");

        switch (answer)
        {
            case "lærer":
                return SearchCriteria.Teacher;
            case "elev":
                return SearchCriteria.Student;
            case "fag":
                return SearchCriteria.Subject;
        }
        return null;


        //Console.WriteLine("Skriv lærerens fulde navn: ");
        //return Console.ReadLine()?.ToLower();

        //Console.WriteLine("Skriv elevens fulde navn: ");
        //return Console.ReadLine()?.ToLower();

        //Console.WriteLine("Skriv fagets fulde navn: ");
        //return Console.ReadLine()?.ToLower();
    }
}
