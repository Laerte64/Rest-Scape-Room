namespace Story;

class Roteiro
{
    public List<Pagina> Paginas { get; set; }

    public Roteiro() 
    {
        Paginas = new List<Pagina>();
    }

    public void Apresentar()
    {
        Console.CursorVisible = true;
        Console.ForegroundColor = ConsoleColor.White;
        foreach (Pagina pagina in Paginas)
            pagina.Apresentar();
        Console.ForegroundColor = ConsoleColor.White;
    }
}