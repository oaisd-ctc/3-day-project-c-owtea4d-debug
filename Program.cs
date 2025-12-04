
using System;
public class Program
{

    static string[] Names = {"martinez", "luyk", "benjamin", "caden", "carlos", "gabriel", "garnold", "izaac", "joseph", "judah", "keira", "lorilei", "lucas", "mason", "nuri", "owent", "owenw", "sage", "tyler"};

    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 18);
        Console.WriteLine(Names[Namesi]);
      //the above writeline is not permanent its just so that we know its generating the names correctly
        Console.WriteLine("Enter a letter to search for:");
        char characterToFind = Console.ReadLine()[0];
    }
    public static void characterChecker(string name, char characterToFind)
    {
        bool characterChecker = false;

        foreach (char letter in name)
        {
            if (letter == characterToFind)
            {
                characterChecker = true;-
            }
            else
            {
                characterChecker = false;
            }
        }
        theHangman(characterChecker);
    }
    public static void theHangman(bool n)
    {
        int counter = 0;
        if (n == false)
        {
            counter = counter + 1;
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

﻿

