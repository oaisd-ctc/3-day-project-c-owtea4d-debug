using System;
public class Program
{

    static int randomNumberCounter;
    static int counter;
    static int scoreCounter;
    static char[] revealedChar;
    public static string result = "abcdefghijklmnopqrstuvwxyz";


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
        Console.WriteLine($"          +---+");
        Console.WriteLine($"          |   |");
        Console.WriteLine($"              |");
        Console.WriteLine($"              |");
        Console.WriteLine($"              |");
        Console.WriteLine($"              |");
        Console.WriteLine($"          =========");
        revealedChar = new char[Names[Namesi].Length];
        for (int i = 0; i < revealedChar.Length; i++)
        {
            revealedChar[i] = '_';
        }

        while (true)
        {
            Console.WriteLine("Enter a letter to search for:");
            char characterToFind = Console.ReadLine()[0];
            Console.WriteLine($"Your score: {scoreCounter}");
            characterChecker(Names[Namesi], characterToFind);
        }

    }


    //-----------------------------------------UI Systems Below 👇------------------------------------------------
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
        Console.WriteLine($"1. Start Game                   Your score: {scoreCounter}");
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
        if (IntConversion == 2)
        {
            gameInstructions();
        }
        if (IntConversion == 3)
        {
            gameSettings();
        }
        if (IntConversion == 4)
        {
            Console.Clear();
            Console.WriteLine("Are You Sure?");
            Console.WriteLine("You will permentally lose your score.");
            Console.Write("Yes or No: ");
            while (true)
            {
                string exitInput = Console.ReadLine().ToLower();
                if (exitInput == "yes")
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                else if (exitInput == "no")
                {
                    Console.Clear();
                    UISystem();
                }
                Console.WriteLine("Invalid Input. Please Try Again.");
            }
        }

    }
    public static void gameSettings()
    {

    }
    public static void gameInstructions()
    {
        Console.WriteLine("Purpose of the Game:");
        Console.WriteLine("Guess the hidden word by choosing letters.");
        Console.WriteLine("Each incorrect guess costs you a life.");
        Console.WriteLine("Survive long enough to reveal the full word");
        Console.WriteLine("How to Enter Guesses");
        Console.WriteLine("Enter one letter at a time");
        Console.WriteLine("Letters must be alphabetic(A-Z).");
        Console.WriteLine("Case does not matter.");
        Console.WriteLine("How Mistakes Work");
        Console.WriteLine("You have 6 lives");
        Console.WriteLine("Each incorrect guess removes one life.");
        Console.WriteLine("If you reach zero, the game ends.");
        Console.WriteLine("Revealing the Word:");
        Console.WriteLine("Correct letters are shown in their positions.");
        Console.WriteLine("Unknown letter remain blanks/underscores.");
        Console.WriteLine("Repeated Guesses:");
        Console.WriteLine("Duplicate guesses do not cost lives.");
        Console.WriteLine("The game will warn you if you already tried that letter.");
        Console.WriteLine("Winning and Losing:");
        Console.WriteLine("Win by guessing all letters before running out of lives.");
        Console.WriteLine("Lose if your lives reach zero; the full word is then revealed.");
        Console.WriteLine("Difficulty Levels:");
        Console.WriteLine("Noob: Out of all the AM students. Guess there name.");
        Console.WriteLine("Pro: Now guess the AM students last names aswell.");
        Console.WriteLine("Hacker: This might be a little challenging. Guess the AM students GITHUB user-names.");
        Console.WriteLine("God: This is by far the easiest 💀💀💀... Lol... its just AM and PM github user-names.");
        Console.WriteLine("Let me know when your ready to return. You better just type 'Ready'");
        while (true)
        {
            string returnToUI = Console.ReadLine().ToLower();
            if (returnToUI == "ready")
            {
                UISystem();
            }
            Console.Write("I dont really care what you typed. 😂");
            Thread.Sleep(500);
            Console.Write(" .");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.WriteLine();
            UISystem();
        }





    }
    public static void gameStarting()
    {
        Console.Clear();
        Console.WriteLine("Select your difficulty");
        Console.WriteLine($"1. Noob - first names");
        Console.WriteLine($"2. Pro - first and last names with capitialization");
        Console.WriteLine($"3. Hacker - github users");
        Console.WriteLine($"4. God - am and pm github users");
        string DifficultyInput = Console.ReadLine();
        Console.Clear();
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
    }


    //-----------------------------------------UI Systems Above 👆------------------------------------------------
    public static void systemABC(char letter)
    {
        char[] l = result.ToCharArray();

        for (int i = 0; i < l.Length; i++)
        {
            if (l[i] == letter)
            {
                l[i] = '-';
                break;
            }
        }
        result = new string(l);


    }

    public static void characterChecker(string name, char characterToFind)
    {
        bool foundChar = false;


        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == characterToFind)
            {
                revealedChar[i] = characterToFind;
                scoreCounter = scoreCounter + 200;
                foundChar = true;
                systemABC(characterToFind);
            }
            if (name[i] != characterToFind)
            {
                systemABC(characterToFind);
            }
        }

        if (foundChar == false)
        {
            scoreCounter = scoreCounter - 100;
        }
        displayRevealedChar();

        theHangman(foundChar);
        GameWon();
    }
    public static void displayRevealedChar()
    {
        Console.WriteLine();

        foreach (char i in revealedChar)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    public static void GameWon()
    {
       bool allRevealed = true;

       foreach (char c in revealedChar)
        {
            if (c == '_')
            {
                allRevealed = false;
                break;
            }
        }

        if (allRevealed)
        {
            Console.WriteLine("Congrats you've won");
            Console.WriteLine($"Final Score: {scoreCounter}");
            Environment.Exit(0);
        }
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
            Console.WriteLine(result);
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
            Console.WriteLine(result);
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
            Console.WriteLine(result);
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
            Console.WriteLine(result);
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
            Console.WriteLine(result);
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
            Console.WriteLine(result);
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
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
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
                Console.WriteLine("uhhhhhhhhhhhh");
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
                UISystem();
            }
            if (credits == "no")
            {
                Console.Clear();
                UISystem();
            }
        }

    }

    //-----------------------------------------Difficulty Systems Below 👇------------------------------------------------
    public static void Noob()
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 18);
        string[] Names = { "martinez", "luyk", "benjamin", "caden", "noah", "gabriel", "garnold", "izaac", "joseph", "judah", "keira", "lorilei", "lucas", "mason", "nuri", "owent", "owenw", "sage", "tyler" };
        noobmode();
        MainMethod(Names, Namesi);
    }
    public static void Pro()
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 18);
        string[] Names = { "Emmanuel Martinez", "Mr Luyk", "Benjamin Potgeter", "Caden Beyer", "Noah Castaneda", "Gabriel Helmus", "Garnold Crump", "Izaac Wilson", "Joseph Heinz", "Judah Hauch", "Keira Carlson", "Lorilei Forbear", "Lucas Raab", "Mason Hart", "Nuri Banks", "Owen TerHorst", "Owen Walsh", "Sage Little", "Tyler Harris" };
        Startingup();
        MainMethod(Names, Namesi);
    }
    public static void Hacker()
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 18);
        string[] Names = { "MrMartinezCTC", "Mr. Luyk", "Ben-Potgeter-student", "Caden-Beyer-Student", "caasebd-debug", "Gabe", "Garnold-Crump-Student", "izwi160-eng", "josephheinz", "judahhauch", "Keira-Carlson-Student", "Lorilei-Forbear-Student", "lucas-raab-student", "Mason-Hart-Student", "Nuri-Banks-Student", "owtea4d-debug", "OwenTHEWALSH", "sali012-pixel", "tyhad04-spec" };
        Startingup();
        MainMethod(Names, Namesi);
    }
    public static void God()
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 40);
        string[] Names = { "MrMartinezCTC", "Mr. Luyk", "Aiden-clark-student", "alex-lawson-student", "Alvaro-Solis-Student", "Andrew-Abramajtys-Student", "Ben-Potgeter-student", "Benjamin-Altman", "caasebd-debug", "Caden-Beyer-Student", "daama6e-del", "Elijah L.", "Elijah-Young-Student", "Finn-McP", "Gabe", "Gabriel", "Garnold-Crump-Student", "Heath-Zylstra-Student", "izwi160-eng", "Jacob-Flores-Student", "josephheinz", "Fish", "judahhauch", "Keira-Carlson-Student", "Landon-Bolt-student", "Liam-Bowerman", "Logan-Stezowski-Student", "Lorilei-Forbear-Student", "lucas-raab-student", "Mason-Hart-Student", "nakn3eb", "Nuri-Banks-Student", "Owen-Downing-Student", "owtea4d-debug", "OwenTHEWALSH", "Ryan-Haug-Student", "sali012-pixel", "Thomas", "tyhad04-spec", "yos" };
        godmode();
        MainMethod(Names, Namesi);


    }
    //-----------------------------------------Difficulty Systems Above 👆------------------------------------------------
}
