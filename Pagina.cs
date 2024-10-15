namespace Story;

class Pagina
{
    public List<string> Paragrafos { get; set; }
    public Questao? Questao { get; set; }

    public Pagina()
    {
        Paragrafos = new List<string> ();
        Questao = null;
    }

    public void Apresentar()
    {
        Console.Clear();
        foreach (string paragrafo in Paragrafos)
            Apresentar(paragrafo);
        if (Questao == null)
            return;
        Questao.Apresentar();
    }

    public void Apresentar(string paragrafo)
    {
        Escrita.Aparecer(paragrafo);
        Console.WriteLine("");
        Escrita.Aparecer("(Continuar)");
        Console.CursorVisible = false;
        Console.ReadKey();
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.CursorVisible = true;
    }
}
