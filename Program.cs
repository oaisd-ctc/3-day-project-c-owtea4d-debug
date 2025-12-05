
using System;
public class Program
{

    static int randomNumberCounter;
    static int counter;
    static int scoreCounter;

    public static void Main(string[] args)
    {
        UISystem();
        if (randomNumberCounter == 1)
        {
            Noob();
        }
        if (randomNumberCounter == 2)
        {
            Pro();
        }
        if (randomNumberCounter == 3)
        {
            Hacker();
        }
        if (randomNumberCounter == 4)
        {
            God();
        }
    }
    public static void MainMethod(string[] Names, int Namesi)
    {

        while (true)
        {
            Console.WriteLine(Names[Namesi]);
            //the above writeline is not permanent its just so that we know its generating the names correctly
            Console.WriteLine(Namesi);
            Console.WriteLine("Enter a letter to search for:");
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
            char characterToFind = Console.ReadLine()[0];
            characterChecker(Names[Namesi], characterToFind);
        }
    }
    public static void UISystem()
    {
        for (int i = 1; i <= 11; i++)
        {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11)
            {
                Console.WriteLine("========================");
                Console.WriteLine("   OPERATION HANGMAN");
                Console.WriteLine("========================");
                Thread.Sleep(500);
                Console.Clear();
            }
            if (i == 2 || i == 4 || i == 6 || i == 8 || i == 10)
            {

                Console.WriteLine();
                Console.WriteLine("   OPERATION HANGMAN");
                Console.WriteLine();
                Thread.Sleep(500);
                Console.Clear();
            }
        }
        Thread.Sleep(1500);
        Console.WriteLine($"1. Start Game");
        Console.WriteLine($"2. Instructions");
        Console.WriteLine($"3. Settings");
        Console.WriteLine($"4. Exit");
        string UIInput = Console.ReadLine();
        int IntConversion = 0;
        bool isConverted = int.TryParse(UIInput, out IntConversion);
        if (IntConversion == 1)
        {
            gameStarting();
        }
        if (IntConversion == 2) { }
        if (IntConversion == 3) { }
        if (IntConversion == 4) { }

    }
    public static void gameStarting()
    {
        Console.Clear();
        Console.WriteLine("Select your difficulty");
        Console.WriteLine($"1. Noob");
        Console.WriteLine($"2. Pro");
        Console.WriteLine($"3. Hacker");
        Console.WriteLine($"4. God");
        string DifficultyInput = Console.ReadLine();
        int IntConversion = 0;
        bool isConverted = int.TryParse(DifficultyInput, out IntConversion);
        if (IntConversion == 1)
        {
            Noob();
            randomNumberCounter = 1;
        }
        if (IntConversion == 2)
        {
            Pro();
            randomNumberCounter = 2;
        }
        if (IntConversion == 3)
        {
            Hacker();
            randomNumberCounter = 3;
        }
        if (IntConversion == 4)
        {
            God();
            randomNumberCounter = 4;
        }
        Console.Clear();
        Console.Write("PLEASE NOTE!!!");
        Console.WriteLine("If you type anything other than a letter or a '-' it will be marked as incorrect and you will be punished for it. you have been warned.");
        Console.WriteLine("You have 5 seconds to prepare.");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("PLEASE NOTE!!!");
        Console.WriteLine("If you type anything other than a letter or a '-' it will be marked as incorrect and you will be punished for it. you have been warned.");
        Console.WriteLine("You have 4 seconds to prepare.");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("PLEASE NOTE!!!");
        Console.WriteLine("If you type anything other than a letter or a '-' it will be marked as incorrect and you will be punished for it. you have been warned.");
        Console.WriteLine("You have 3 seconds to prepare.");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("PLEASE NOTE!!!");
        Console.WriteLine("If you type anything other than a letter or a '-' it will be marked as incorrect and you will be punished for it. you have been warned.");
        Console.WriteLine("You have 2 seconds to prepare.");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("PLEASE NOTE!!!");
        Console.WriteLine("If you type anything other than a letter or a '-' it will be marked as incorrect and you will be punished for it. you have been warned.");
        Console.WriteLine("You have 1 seconds to prepare.");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("Game Is Starting");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Console.Clear();
    }
    public static void characterChecker(string name, char characterToFind)
    {
        bool foundChar = false;
        string rightorwrong = characterToFind.ToString();
        if (rightorwrong.Length >= 2)
            {
                Console.WriteLine("Please enter 1 character at a time. try again.");
            }
        
        foreach (char letter in name)
        {
            if (letter == characterToFind)
            {
                foundChar = true;
                scoreCounter = scoreCounter + 200;
                break;
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
                Console.WriteLine("Izaac");
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
            if (credits == "no")
            {
                Console.Clear();
            }
        }

    }
    public static void Noob()
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 18);
        string[] Names = { "martinez", "luyk", "benjamin", "caden", "noah", "gabriel", "garnold", "izaac", "joseph", "judah", "keira", "lorilei", "lucas", "mason", "nuri", "owent", "owenw", "sage", "tyler" };
        MainMethod(Names, Namesi);
    }
    public static void Pro()
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 18);
        string[] Names = { "Emmanuel Martinez", "Mr Luyk", "Benjamin Potgeter", "Caden Beyer", "Noah Castaneda", "Gabriel Helmus", "Garnold Crump", "Izaac Wilson", "Joseph Heinz", "Judah Hauch", "Keira Carlson", "Lorilei Forbear", "Lucas Raab", "Mason Hart", "Nuri Banks", "Owen TerHorst", "Owen Walsh", "Sage Little", "Tyler Harris" };
        MainMethod(Names, Namesi);
    }
    public static void Hacker()
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 18);
        string[] Names = { "MrMartinezCTC", "Mr. Luyk", "Ben-Potgeter-student", "Caden-Beyer-Student", "caasebd-debug", "Gabe", "Garnold-Crump-Student", "izwi160-eng", "josephheinz", "judahhauch", "Keira-Carlson-Student", "Lorilei-Forbear-Student", "lucas-raab-student", "Mason-Hart-Student", "Nuri-Banks-Student", "owtea4d-debug", "OwenTHEWALSH", "sali012-pixel", "tyhad04-spec" };
        MainMethod(Names, Namesi);
    }
    public static void God()
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 40);
        string[] Names = { "MrMartinezCTC", "Mr. Luyk", "Aiden-clark-student", "alex-lawson-student", "Alvaro-Solis-Student", "Andrew-Abramajtys-Student", "Ben-Potgeter-student", "Benjamin-Altman", "caasebd-debug", "Caden-Beyer-Student", "daama6e-del", "Elijah L.", "Elijah-Young-Student", "Finn-McP", "Gabe", "Gabriel", "Garnold-Crump-Student", "Heath-Zylstra-Student", "izwi160-eng", "Jacob-Flores-Student", "josephheinz", "Fish", "judahhauch", "Keira-Carlson-Student", "Landon-Bolt-student", "Liam-Bowerman", "Logan-Stezowski-Student", "Lorilei-Forbear-Student", "lucas-raab-student", "Mason-Hart-Student", "nakn3eb", "Nuri-Banks-Student", "Owen-Downing-Student", "owtea4d-debug", "OwenTHEWALSH", "Ryan-Haug-Student", "sali012-pixel", "Thomas", "tyhad04-spec", "yos" };
        MainMethod(Names, Namesi);


    }
}
