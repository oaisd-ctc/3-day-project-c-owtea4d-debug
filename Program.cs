using System;
public class Program
{
    static string[] loader = { "■□□", "■■□", "■■■" };
    static int[] loaderTimerMS = { 1000, 3 };
    static string currentWord;
    static int globalNameLength;
    static int randomNumberCounter;
    static int counter;
    static int scoreCounter;
    static bool Loser;
    static char[] revealedChar;
    public static string abcResult = "abcdefghijklmnopqrstuvwxyz";

    //--------------------------------------------------Mains👇-------------------------------------------------------
    public static void Main(string[] args)
    {
        titleScreen();
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
        if (randomNumberCounter == 5)
        {
            Food();
        }
        if (randomNumberCounter == 6)
        {
            RandomWords();
        }
    }
    public static void MainMethod(string[] Names, int Namesi)
    {
        currentWord = Names[Namesi];
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
        globalNameLength = revealedChar.Length;
        while (true)
        {
            Console.WriteLine("Enter a letter to search for:");
            string firstInput = Console.ReadLine();
            char characterToFind = firstInput[0];
            commandCenter(firstInput);
            Console.Clear();
            Console.WriteLine($"Your score: {scoreCounter}");
            characterChecker(Names[Namesi], characterToFind);

        }

    }
    public static void loadingProcess()
    {
        for (int i = 0; i < loaderTimerMS[1]; i++)
        {
            Console.Clear();
            Console.Write(loader[i]);
            Thread.Sleep(loaderTimerMS[0]);
        }

        Console.Clear();
    }

    //-----------------Commands👇--------------------------------
    public static void commandCenter(string mainInput)
    {
        if (mainInput.ToLower() == "end" || mainInput.ToLower() == "back")
        {
            loadingProcess();
            UISystem();
        }
    }
    //--------------------Commands👆-----------------------------

    //-----------------------------------------UI Systems Below 👇------------------------------------------------
    public static void titleScreen()
    {
        Console.Clear();
        Thread.Sleep(1);
        for (int i = 1; i <= 13; i++)
        {
            if (i == 1 || i == 4 || i == 7 || i == 10)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 0);
                Console.WriteLine(" ██████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(50, 1);
                Console.WriteLine(" ██████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(50, 2);
                Console.WriteLine(" ██████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(50, 3);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
                                                    ____  _____  ______ _____         _______ _____  ____  _   _    
                                                    / __ \|  __ \|  ____|  __ \     /\|__   __|_   _/ __ \| \ | | 
                                                    | |  | | |__) | |__  | |__) |   /  \  | |    | || |  ||  \| |
                                                    | |  | |  ___/|  __| |  _  /   / /\ \ | |    | || |  || . ` |  
                                                    | |__| | |    | |____| | \ \  / ____ \| |   _| || |__|| |\  |  
                                                    \____/|_|    |______|_|  \_\/_/    \_\_|  |_____\____/|_| \_| 
                                                        _    _          _   _  _____ __  __          _   _    
                                                        | |  | |   /\   | \ | |/ ____|  \/  |   /\   | \ | |   
                                                        | |__| |  /  \  |  \| | |  __| \  / |  /  \  |  \| |   
                                                        |  __  | / /\ \ | . ` | | |_ | |\/| | / /\ \ | . ` |   
                                                        | |  | |/ ____ \| |\  | |__| | |  | |/ ____ \| |\  |   
                                                        |_|  |_/_/    \_\_| \_|\_____|_|  |_/_/    \_\_| \_|   
            ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 18);
                Console.WriteLine(" ██████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(50, 19);
                Console.WriteLine(" ██████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(50, 20);
                Console.WriteLine(" ██████████████████████████████████████████████████████████████");
                Thread.Sleep(500);
                Console.Clear();
            }
            if (i == 2 || i == 5 || i == 8 || i == 11)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 0);
                Console.WriteLine(" ");
                Console.SetCursorPosition(50, 1);
                Console.WriteLine("            ███████████████████████████████████████            ");
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("            ███████████████████████████████████████            ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(50, 3);
                Console.WriteLine(@"
                                                    ____  _____  ______ _____         _______ _____  ____  _   _    
                                                    / __ \|  __ \|  ____|  __ \     /\|__   __|_   _/ __ \| \ | | 
                                                    | |  | | |__) | |__  | |__) |   /  \  | |    | || |  ||  \| |
                                                    | |  | |  ___/|  __| |  _  /   / /\ \ | |    | || |  || . ` |  
                                                    | |__| | |    | |____| | \ \  / ____ \| |   _| || |__|| |\  |  
                                                    \____/|_|    |______|_|  \_\/_/    \_\_|  |_____\____/|_| \_| 
                                                        _    _          _   _  _____ __  __          _   _    
                                                        | |  | |   /\   | \ | |/ ____|  \/  |   /\   | \ | |   
                                                        | |__| |  /  \  |  \| | |  __| \  / |  /  \  |  \| |   
                                                        |  __  | / /\ \ | . ` | | |_ | |\/| | / /\ \ | . ` |   
                                                        | |  | |/ ____ \| |\  | |__| | |  | |/ ____ \| |\  |   
                                                        |_|  |_/_/    \_\_| \_|\_____|_|  |_/_/    \_\_| \_|   
            ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 18);
                Console.WriteLine("            ███████████████████████████████████████            ");
                Console.SetCursorPosition(50, 19);
                Console.WriteLine("            ███████████████████████████████████████            ");
                Console.SetCursorPosition(50, 20);
                Console.WriteLine(" ");
                Thread.Sleep(500);
                Console.Clear();
            }
            if (i == 3 || i == 6 || i == 9 || i == 12)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 0);
                Console.WriteLine(" ");
                Console.SetCursorPosition(50, 1);
                Console.WriteLine(" ");
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("                      ██████████████████                       ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(50, 3);
                Console.WriteLine(@"
                                                    ____  _____  ______ _____         _______ _____  ____  _   _    
                                                    / __ \|  __ \|  ____|  __ \     /\|__   __|_   _/ __ \| \ | | 
                                                    | |  | | |__) | |__  | |__) |   /  \  | |    | || |  ||  \| |
                                                    | |  | |  ___/|  __| |  _  /   / /\ \ | |    | || |  || . ` |  
                                                    | |__| | |    | |____| | \ \  / ____ \| |   _| || |__|| |\  |  
                                                    \____/|_|    |______|_|  \_\/_/    \_\_|  |_____\____/|_| \_| 
                                                        _    _          _   _  _____ __  __          _   _    
                                                        | |  | |   /\   | \ | |/ ____|  \/  |   /\   | \ | |   
                                                        | |__| |  /  \  |  \| | |  __| \  / |  /  \  |  \| |   
                                                        |  __  | / /\ \ | . ` | | |_ | |\/| | / /\ \ | . ` |   
                                                        | |  | |/ ____ \| |\  | |__| | |  | |/ ____ \| |\  |   
                                                        |_|  |_/_/    \_\_| \_|\_____|_|  |_/_/    \_\_| \_|   
            ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 18);
                Console.WriteLine("                      ██████████████████                       ");
                Console.SetCursorPosition(50, 19);
                Console.WriteLine(" ");
                Console.SetCursorPosition(50, 20);
                Console.WriteLine(" ");
                Thread.Sleep(500);
                Console.Clear();
                Console.SetCursorPosition(50, 0);
                Console.WriteLine(" ");
                Console.SetCursorPosition(50, 1);
                Console.WriteLine(" ");
                Console.SetCursorPosition(50, 2);
                Console.WriteLine(" ");
                Console.WriteLine(@"
                                                    ____  _____  ______ _____         _______ _____  ____  _   _    
                                                    / __ \|  __ \|  ____|  __ \     /\|__   __|_   _/ __ \| \ | | 
                                                    | |  | | |__) | |__  | |__) |   /  \  | |    | || |  ||  \| |
                                                    | |  | |  ___/|  __| |  _  /   / /\ \ | |    | || |  || . ` |  
                                                    | |__| | |    | |____| | \ \  / ____ \| |   _| || |__|| |\  |  
                                                    \____/|_|    |______|_|  \_\/_/    \_\_|  |_____\____/|_| \_| 
                                                        _    _          _   _  _____ __  __          _   _    
                                                        | |  | |   /\   | \ | |/ ____|  \/  |   /\   | \ | |   
                                                        | |__| |  /  \  |  \| | |  __| \  / |  /  \  |  \| |   
                                                        |  __  | / /\ \ | . ` | | |_ | |\/| | / /\ \ | . ` |   
                                                        | |  | |/ ____ \| |\  | |__| | |  | |/ ____ \| |\  |   
                                                        |_|  |_/_/    \_\_| \_|\_____|_|  |_/_/    \_\_| \_|   
            ");
                Console.SetCursorPosition(50, 18);
                Console.WriteLine(" ");
                Console.SetCursorPosition(50, 19);
                Console.WriteLine(" ");
                Console.SetCursorPosition(50, 20);
                Console.WriteLine(" ");
                Thread.Sleep(500);
                Console.Clear();
            }
            if (i == 13)
            {
                string q = " █";


                for (int n = 0; n <= 20; n++)
                {
                    Console.Write(q);
                    Thread.Sleep(200);
                    if (n == 20)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
        }
        Console.ResetColor();
    }
    public static void UISystem()
    {
        Console.SetCursorPosition(0, 0);
        Thread.Sleep(1500);
        int IntConversion = 0;
        Console.WriteLine($"1. Start Game                   Your score: {scoreCounter}");
        Console.WriteLine($"2. Instructions");
        Console.WriteLine($"3. Settings");
        Console.WriteLine($"4. Exit");
        while (true)
        {
            string UIInput = Console.ReadLine();
            if (UIInput == "1" || UIInput == "2" || UIInput == "3" || UIInput == "4")
            {
                bool isConverted = int.TryParse(UIInput, out IntConversion);
                break;
            }
            Console.WriteLine("Please Try Again");
        }


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
        Console.Clear();
        Console.WriteLine("there are no settings. but say hi to shrek while your here!");
        Console.WriteLine("⢀⡴⠑⡄⠀⠀⠀⠀⠀⠀⠀⣀⣀⣤⣤⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠸⡇⠀⠿⡀⠀⠀⠀⣀⡴⢿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⠀⠀⠀⠑⢄⣠⠾⠁⣀⣄⡈⠙⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⠀⠀⠀⢀⡀⠁⠀⠀⠈⠙⠛⠂⠈⣿⣿⣿⣿⣿⠿⡿⢿⣆⠀⠀⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⠀⠀⢀⡾⣁⣀⠀⠴⠂⠙⣗⡀⠀⢻⣿⣿⠭⢤⣴⣦⣤⣹⠀⠀⠀⢀⢴⣶⣆ ");
        Console.WriteLine("⠀⠀⢀⣾⣿⣿⣿⣷⣮⣽⣾⣿⣥⣴⣿⣿⡿⢂⠔⢚⡿⢿⣿⣦⣴⣾⠁⠸⣼⡿ ");
        Console.WriteLine("⠀⢀⡞⠁⠙⠻⠿⠟⠉⠀⠛⢹⣿⣿⣿⣿⣿⣌⢤⣼⣿⣾⣿⡟⠉⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⣾⣷⣶⠇⠀⠀⣤⣄⣀⡀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⠉⠈⠉⠀⠀⢦⡈⢻⣿⣿⣿⣶⣶⣶⣶⣤⣽⡹⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠉⠲⣽⡻⢿⣿⣿⣿⣿⣿⣿⣷⣜⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣶⣮⣭⣽⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⣀⣀⣈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀ ");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠻⠿⠿⠿⠿⠛⠉");
        Console.WriteLine("Let me know when your ready to return, type 'Ready'");
        while (true)
        {
            string returnToUI = Console.ReadLine().ToLower();
            if (returnToUI == "ready")
            {
                Console.Clear();
                UISystem();
            }
            Console.Write("idc what you typed.");
            Thread.Sleep(500);
            Console.Write(" .");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.WriteLine();
            Console.Clear();
            UISystem();
        }
    }
    public static void gameInstructions()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Purpose of the Game:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Guess the hidden word by choosing letters.");
        Console.WriteLine("Each incorrect guess costs you a life.");
        Console.WriteLine("Survive long enough to reveal the full word");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("How to Enter Guesses:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Enter one letter at a time");
        Console.WriteLine("Letters must be alphabetic(A-Z).");
        Console.WriteLine("Capitalization does matter.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("How Mistakes Work:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You have 6 lives");
        Console.WriteLine("Each incorrect guess removes one life.");
        Console.WriteLine("If you reach zero, the game ends.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Revealing the Word:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Correct letters are shown in their positions.");
        Console.WriteLine("Unknown letter remain blanks/underscores.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Repeated Guesses:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Duplicate guesses do not cost lives.");
        Console.WriteLine("The game will warn you if you already tried that letter.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Winning and Losing:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Win by guessing all letters before running out of lives.");
        Console.WriteLine("Lose if your lives reach zero; the full word is then revealed.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Difficulty Levels:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Noob: Out of all the AM students. Guess there name.");
        Console.WriteLine("Pro: Now guess the AM students last names aswell.");
        Console.WriteLine("Hacker: This might be a little challenging. Guess the AM students GITHUB user-names.");
        Console.WriteLine("God: This is by far the easiest 💀💀💀... Lol... its just AM and PM github user-names.");
        Console.WriteLine("Food: This is just a bunch of random foods generate by AI.");
        Console.WriteLine("RandomWords: 40 random generated words form the Encyclopedia. Good Luck.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Commands:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("● End/Back - Want to end the game early? Try this!");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Let me know when your ready to return. You better just type 'Ready'");
        Console.ResetColor();
        while (true)
        {
            string returnToUI = Console.ReadLine().ToLower();
            Console.Clear();
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
            Console.Clear();
            UISystem();
        }

    }
    public static void gameStarting()
    {
        counter = 0;
        Console.Clear();
        Console.WriteLine("Select your difficulty");
        Console.WriteLine($"1. Noob - first names");
        Console.WriteLine($"2. Pro - first and last names with capitialization");
        Console.WriteLine($"3. Hacker - github users (CASE SENSITIVE)");
        Console.WriteLine($"4. God - am and pm github users (CASE SENSITIVE)");
        Console.WriteLine($"5. Food - this is a list of 40 different foods (CASE SENSITIVE)");
        Console.WriteLine($"6. Encyclopedia - this has 40 different words from the encyclopedia (CASE SENSITIVE)");
        string DifficultyInput;
        while (true)
        {
            DifficultyInput = Console.ReadLine();
            if (DifficultyInput == "1" || DifficultyInput == "2" || DifficultyInput == "3" || DifficultyInput == "4" || DifficultyInput == "5" || DifficultyInput == "6")
            {
                break;
            }
            Console.WriteLine("Please Try Again.");
        }
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
        if (IntConversion == 5)
        {
            Food();
            randomNumberCounter = 5;
        }
        if (IntConversion == 6)
        {
            RandomWords();
            randomNumberCounter = 6;
        }

    }
    //-----------------------------------------UI Systems Above 👆------------------------------------------------
    public static void systemABC(char letter, bool foundChar)
    {
        char[] l = abcResult.ToCharArray();

        for (int i = 0; i < l.Length; i++)
        {
            if (l[i] == letter)
            {
                if (foundChar == true)
                {
                    l[i] = '✔';
                    break;
                }
                if (foundChar == false)
                {
                    l[i] = '✘';
                    break;
                }
            }
        }
        abcResult = new string(l);
    }

    public static void scoreSystem(bool W)
    {
        if (W == true)
        {
            scoreCounter = scoreCounter + (200 * globalNameLength);
        }
        if (Loser == true)
        {
            scoreCounter = scoreCounter + (100 * globalNameLength);
        }
    }
    public static void characterChecker(string name, char characterToFind)
    {
        bool foundChar = false;


        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == characterToFind)
            {
                revealedChar[i] = characterToFind;
                foundChar = true;
                systemABC(characterToFind, foundChar);
            }
        }

        if (foundChar == false)
        {
            systemABC(characterToFind, foundChar);
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
            Thread.Sleep(1250);
            Console.Write(".");
            Thread.Sleep(1250);
            Console.Write(".");
            Thread.Sleep(1250);
            Console.Write(".");
            Thread.Sleep(1250);
            abcResult = "abcdefghijklmnopqrstuvwxyz";
            Console.Clear();
            scoreSystem(allRevealed);
            Console.WriteLine("Congrats you've won");
            Console.WriteLine($"Final Score: {scoreCounter}");
            Thread.Sleep(3000);
            Console.Clear();
            UISystem();
        }
    }
    public static void Startingup()
    {
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
        Console.WriteLine("You have 1 second to prepare.");
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
    public static void noobmode()
    {
        Console.Clear();
        Console.WriteLine("Aw you choose noob mode how completely ok of you to do so I dont blame you the other modes is scary 🥶.");
        Thread.Sleep(2000);
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
        Console.WriteLine("You have 1 second to prepare.");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Oh one more thing before you start. The Owens, since they have the same name, have their last initial right after their name. no spaces. ex: 'owent' 'owenw'");
        Console.WriteLine("Ill give you 10 more seconds to prepare");
        Thread.Sleep(10000);
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
    public static void godmode()
    {
        Console.Clear();
        Console.WriteLine("HOLY GUACAMOLE YOU PICKED GOD MODE1!11!!11!😱😱😱😲😲😲🤯🤯🤯 YOU MUST BE SMART");
        Thread.Sleep(2000);
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
        Console.WriteLine("You have 1 second to prepare.");
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
        Console.WriteLine("Good luck, you're gonna need it broski🤞");
        Thread.Sleep(3000);
        Console.Clear();
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
            Console.WriteLine(abcResult);
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
            Console.WriteLine(abcResult);
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
            Console.WriteLine(abcResult);
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
            Console.WriteLine(abcResult);
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
            Console.WriteLine(abcResult);
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
            Console.WriteLine(abcResult);
        }
        else if (counter == 6)
        {
            Loser = true;
            Console.WriteLine(@"          +---+");
            Console.WriteLine(@"          |   |");
            Console.WriteLine(@"          0   |");
            Console.WriteLine(@"         /|\  |");
            Console.WriteLine(@"         / \  |");
            Console.WriteLine(@"              |");
            Console.WriteLine(@"          =========");

            abcResult = "abcdefghijklmnopqrstuvwxyz";
            Thread.Sleep(1500);
            Console.Clear();
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Clear();
            Thread.Sleep(300);
            Console.WriteLine();
            Console.WriteLine($"Game Over. Nice Try. ");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"The word you got incorrect was: {currentWord}");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1250);
            Console.Write(".");
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
                Console.WriteLine("Shrek");
                Thread.Sleep(1100);
                Console.WriteLine("the inspiration behind it all");
                Thread.Sleep(900);
                Console.WriteLine("⢀⡴⠑⡄⠀⠀⠀⠀⠀⠀⠀⣀⣀⣤⣤⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                Console.WriteLine("⠸⡇⠀⠿⡀⠀⠀⠀⣀⡴⢿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⠀⠀⠀⠑⢄⣠⠾⠁⣀⣄⡈⠙⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⠀⠀⠀⢀⡀⠁⠀⠀⠈⠙⠛⠂⠈⣿⣿⣿⣿⣿⠿⡿⢿⣆⠀⠀⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⠀⠀⢀⡾⣁⣀⠀⠴⠂⠙⣗⡀⠀⢻⣿⣿⠭⢤⣴⣦⣤⣹⠀⠀⠀⢀⢴⣶⣆ ");
                Console.WriteLine("⠀⠀⢀⣾⣿⣿⣿⣷⣮⣽⣾⣿⣥⣴⣿⣿⡿⢂⠔⢚⡿⢿⣿⣦⣴⣾⠁⠸⣼⡿ ");
                Console.WriteLine("⠀⢀⡞⠁⠙⠻⠿⠟⠉⠀⠛⢹⣿⣿⣿⣿⣿⣌⢤⣼⣿⣾⣿⡟⠉⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⣾⣷⣶⠇⠀⠀⣤⣄⣀⡀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⠉⠈⠉⠀⠀⢦⡈⢻⣿⣿⣿⣶⣶⣶⣶⣤⣽⡹⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠉⠲⣽⡻⢿⣿⣿⣿⣿⣿⣿⣷⣜⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣶⣮⣭⣽⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⣀⣀⣈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀ ");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠻⠿⠿⠿⠿⠛⠉");
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
        string[] Names = { "Emmanuel Martinez", "Collin Luyk", "Benjamin Potgeter", "Caden Beyer", "Noah Castaneda", "Gabriel Helmus", "Garnold Crump", "Izaac Wilson", "Joseph Heinz", "Judah Hauch", "Keira Carlson", "Lorilei Forbear", "Lucas Raab", "Mason Hart", "Nuri Banks", "Owen TerHorst", "Owen Walsh", "Sage Little", "Tyler Harris" };
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
    public static void Food()
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 40);
        string[] Names = { "Pizza", "Burger", "Pasta", "Sushi", "Tacos", "Sandwich", "Salad", "Steak", "Chicken", "Rice", "Noodles", "Soup", "Fries", "Hot Dog", "Pancakes", "Waffles", "Ice Cream", "Cake", "Donuts", "Cookies", "Chocolate", "Apple", "Banana", "Orange", "Strawberries", "Grapes", "Cheese", "Eggs", "Bacon", "Sausage", "Fish", "Shrimp", "Pizza Rolls", "Nachos", "Popcorn", "Cereal", "Yogurt", "Oatmeal", "Peanut Butter", "Jelly" };
        Startingup();
        MainMethod(Names, Namesi);
    }
    public static void RandomWords()
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 40);
        string[] Names = { "Atom", "Galaxy", "Democracy", "Photosynthesis", "Volcano", "Algorithm", "Mythology", "Ecosystem", "Gravity", "Renaissance", "Quantum", "Bacteria", "Civilization", "Architecture", "Philosophy", "Meteorology", "Evolution", "Astronomy", "Linguistics", "Geography", "Archaeology", "Economics", "Psychology", "Mathematics", "Engineering", "Navigation", "Electricity", "Magnetism", "Anthropology", "Genetics", "Cartography", "Oceanography", "Cryptography", "Thermodynamics", "Optics", "Acoustics", "Topology", "Nanotechnology", "Ecology", "Sociology" };
        Startingup();
        MainMethod(Names, Namesi);
    }
    //-----------------------------------------Difficulty Systems Above 👆------------------------------------------------
}
