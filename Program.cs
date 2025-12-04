public class Program
{
    static string[] Names = {"martinez", "luyk", "benjamin", "caden", "carlos", "gabriel", "garnold", "izaac", "joseph", "judah", "keira", "lorilei", "lucas", "mason", "nuri","owent","owenw", "sage", "tyler"};
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int Namesi = rnd.Next(0, 18);
        Console.WriteLine(Names[Namesi]);
    }
}