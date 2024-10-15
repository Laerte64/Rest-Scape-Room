namespace Story;

class Escrita
{
    public static void Aparecer(string texto)
    {
        ConsoleColor color = Console.ForegroundColor;
        bool isString = false;
        foreach (char c in texto)
        {
            isString ^= c == '"';
            Console.ForegroundColor = isString ? ConsoleColor.Green : color;
            Console.Write(c);
            Thread.Sleep(10);
        }
        Console.ForegroundColor = color;
        Console.WriteLine("");
    }
}