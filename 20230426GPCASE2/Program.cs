

using static _20230426GPCASE2.Codes.Utility;

Criteria? Search()
{
    Console.WriteLine("Hej velkommen til TEC HF1!");
    Console.WriteLine("Hvad kunne du tænke dig at søge på?");
    Console.WriteLine("Lærer, Elev eller Fag: ");
    var answer = Console.ReadLine()?.ToLower();

    if (string.IsNullOrEmpty(answer) || !answer.Equals("lærer") && !answer.Equals("elev") && !answer.Equals("fag"))
    {
        Console.Clear();
        Console.WriteLine($"!! Error, {answer} does not exist. Rebooting program.");

        switch (answer)
        {
            case "lærer":
                return Criteria.Teacher;
            case "elev":
                return Criteria.Student;
            case "fag":
                return Criteria.Subject;
        }
    }
}
