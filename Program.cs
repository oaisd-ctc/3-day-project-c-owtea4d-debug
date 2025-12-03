using System;
public class Program
{
    public static void Main(string[] args)
    {
        theHangman(true);
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
        else if(counter == 1)
        {
            Console.WriteLine($"          +---+");
            Console.WriteLine($"          |   |");
            Console.WriteLine($"          0   |");
            Console.WriteLine($"              |");
            Console.WriteLine($"              |");
            Console.WriteLine($"              |");
            Console.WriteLine($"          =========");
        }
    }
}
