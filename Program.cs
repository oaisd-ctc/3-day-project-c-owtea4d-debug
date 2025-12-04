
using System;
public class Program
{

    static int counter = 0;
    static string[] Names = {"martinez", "luyk", "benjamin", "caden", "carlos", "gabriel", "garnold", "izaac", "joseph", "judah", "keira", "lorilei", "lucas", "mason", "nuri", "owent", "owenw", "sage", "tyler"};

    static string[] Names = {};

    public static void Main(string[] args)
    {
    
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 18);
        while (true)
        {
        Console.WriteLine(Names[Namesi]);
      //the above writeline is not permanent its just so that we know its generating the names correctly
        Console.WriteLine("Enter a letter to search for:");
        char characterToFind = Console.ReadLine()[0];
        characterChecker(Names[Namesi], characterToFind);
        }
    }
    public static void characterChecker(string name, char characterToFind)
    {
        bool foundChar = false;

        foreach (char letter in name)
        {
            if (letter == characterToFind)
            {
                foundChar = true;
                break;
                characterChecker = true;
            }
            else
            {
                characterChecker = false;

            }
        }
        theHangman(foundChar);
    }
    public static void theHangman(bool foundChar)
    {
       if (!foundChar)
        {
            counter++;
        }
        if (counter == 0)
        {
            Console.WriteLine($"          +---+");
            Console.WriteLine($"          |   |");
            Console.WriteLine($"              |");
            Console.WriteLine($"              |");
            Console.WriteLine($"              |");
            Console.WriteLine($"              |");
            Console.WriteLine($"          =========");
        }
        else if (counter == 1)
        {
            Console.WriteLine($"          +---+");
            Console.WriteLine($"          |   |");
            Console.WriteLine($"          0   |");
            Console.WriteLine($"              |");
            Console.WriteLine($"              |");
            Console.WriteLine($"              |");
            Console.WriteLine($"          =========");
        }
        else if (counter == 2)
        {
            Console.WriteLine($"          +---+");
            Console.WriteLine($"          |   |");
            Console.WriteLine($"          0   |");
            Console.WriteLine($"          |   |");
            Console.WriteLine($"              |");
            Console.WriteLine($"              |");
            Console.WriteLine($"          =========");
        }
        else if (counter == 3)
        {
            Console.WriteLine(@"          +---+");
            Console.WriteLine(@"          |   |");
            Console.WriteLine(@"          0   |");
            Console.WriteLine(@"         /|   |");
            Console.WriteLine(@"              |");
            Console.WriteLine(@"              |");
            Console.WriteLine(@"          =========");
        }
        else if (counter == 4)
        {
            Console.WriteLine(@"          +---+");
            Console.WriteLine(@"          |   |");
            Console.WriteLine(@"          0   |");
            Console.WriteLine(@"         /|\  |");
            Console.WriteLine(@"              |");
            Console.WriteLine(@"              |");
            Console.WriteLine(@"          =========");
        }
        else if (counter == 5)
        {
            Console.WriteLine(@"          +---+");
            Console.WriteLine(@"          |   |");
            Console.WriteLine(@"          0   |");
            Console.WriteLine(@"         /|\  |");
            Console.WriteLine(@"         /    |");
            Console.WriteLine(@"              |");
            Console.WriteLine(@"          =========");
        }
        else if (counter == 6)
        {
            Console.WriteLine(@"          +---+");
            Console.WriteLine(@"          |   |");
            Console.WriteLine(@"          0   |");
            Console.WriteLine(@"         /|\  |");
            Console.WriteLine(@"         / \  |");
            Console.WriteLine(@"              |");
            Console.WriteLine(@"          =========");

            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine(".");
            Thread.Sleep(300);
            Console.WriteLine(".");
            Thread.Sleep(300);
            Console.WriteLine(".");
            Thread.Sleep(300);
            Console.WriteLine();
            Console.WriteLine($"Game Over. Nice Try.");
            Console.WriteLine();
            Thread.Sleep(1250);
            Console.Clear();
            Console.WriteLine("Want to watch the credits? yes or no");
            string credits = Console.ReadLine().ToLower();
            if (credits == "yes")
            {
                Console.WriteLine("Credits:");
                Thread.Sleep(1500);
                Console.WriteLine();
                Console.WriteLine("Tyler");
                Thread.Sleep(1100);
                Console.WriteLine("Monster feind");
                Thread.Sleep(900);
                Console.WriteLine("The Sleeper");
                Thread.Sleep(900);
                Console.WriteLine("Light Work he says");
                Thread.Sleep(1500);
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Isaak");
                Thread.Sleep(1100);
                Console.WriteLine("Brain behind it all");
                Thread.Sleep(900);
                Console.WriteLine("True Gamer");
                Thread.Sleep(900);
                Console.WriteLine("Intensive Coder");
                Thread.Sleep(1500);
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Owen");
                Thread.Sleep(1100);
                Console.WriteLine("brb");
                Thread.Sleep(900);
                Console.WriteLine("ngl");
                Thread.Sleep(900);
                Console.WriteLine("tbh");
                Thread.Sleep(900);
                Console.Clear();
            }
            if(credits == "no")
            {
                Console.Clear();
            }
        }

    }
    public static void Noob()
    {
        string[] Names = {"martinez", "luyk", "benjamin", "caden", "noah", "gabriel", "garnold", "izaac", "joseph", "judah", "keira", "lorilei", "lucas", "mason", "nuri", "owent", "owenw", "sage", "tyler"};
    }
    public static void Pro()
    {
        string[] Names = {"Emmanuel Martinez", "Mr Luyk", "Benjamin Potgeter", "Caden Beyer", "Noah Castaneda", "Gabriel Helmus", "Garnold Crump", "Izaac Wilson", "Joseph Heinz", "Judah Hauch", "Keira Carlson", "Lorilei Forbear", "Lucas Raab", "Mason Hart", "Nuri Banks", "Owen TerHorst", "Owen Walsh", "Sage Little", "Tyler Harris"};
    }
    public static void Hacker()
    {
        string[] Names = {"MrMartinezCTC", "Mr. Luyk", "Ben-Potgeter-student", "Caden-Beyer-Student", "caasebd-debug", "Gabe", "Garnold-Crump-Student", "izwi160-eng", "josephheinz", "judahhauch", "Keira-Carlson-Student", "Lorilei-Forbear-Student", "lucas-raab-student", "Mason-Hart-Student", "Nuri-Banks-Student", "owtea4d-debug", "OwenTHEWALSH", "sali012-pixel", "tyhad04-spec"};
    }
    public static void God()
    {
        string[] Names = {"MrMartinezCTC", "Mr. Luyk", "Aiden-clark-student", "alex-lawson-student", "Alvaro-Solis-Student", "Andrew-Abramajtys-Student", "Ben-Potgeter-student", "Benjamin-Altman", "caasebd-debug", "Caden-Beyer-Student", "daama6e-del", "Elijah L.", "Elijah-Young-Student", "Finn-McP", "Gabe", "Gabriel", "Garnold-Crump-Student", "Heath-Zylstra-Student", "izwi160-eng", "Jacob-Flores-Student", "josephheinz", "Fish", "judahhauch", "Keira-Carlson-Student", "Landon-Bolt-student", "Liam-Bowerman", "Logan-Stezowski-Student", "Lorilei-Forbear-Student", "lucas-raab-student", "Mason-Hart-Student", "nakn3eb", "Nuri-Banks-Student", "Owen-Downing-Student", "owtea4d-debug", "OwenTHEWALSH", "Ryan-Haug-Student", "sali012-pixel", "Thomas", "tyhad04-spec", "yos"};
    }
}
