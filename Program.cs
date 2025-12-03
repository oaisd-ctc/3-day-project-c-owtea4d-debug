using System;
public class Program
{
    public static void Main(string []args)
    {
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

    }
}
