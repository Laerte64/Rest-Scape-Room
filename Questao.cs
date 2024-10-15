namespace Story;

class Questao
{
    public string Pergunta { get; set; }
    public List<string> Alternativas { get; set; }
    public int Resposta { get; set; }

    public Questao()
    {
        Pergunta = "";
        Alternativas = new List<string>();
        Resposta = 0;
    }

    public void Apresentar()
    {
        Console.CursorVisible = true;
        Escrita.Aparecer(Pergunta);
        Console.WriteLine("");
        string[] letras = {"A", "B", "C", "D"};
        for (int i = 0; i < 4; i++)
            Escrita.Aparecer(letras[i] + " - " + Alternativas[i]);
        Console.WriteLine("");
        Console.Write("(Pressione a Opção)");
        Console.CursorVisible = false;
        while (!EsperarResposta());
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("(Continuar)           ");
        Console.ReadKey();
        Console.CursorVisible = true;
    }

    public bool EsperarResposta()
    {
        int opcao = Console.ReadKey(true).KeyChar - 'a';
        if (opcao < 0 || opcao > 3)
            return false;
        bool acerto = opcao == Resposta;
        Console.SetCursorPosition(0, Console.CursorTop - 5 + opcao);
        Console.ForegroundColor = acerto ? ConsoleColor.Green : ConsoleColor.Red;
        Escrita.Aparecer(new List<string>(){"A", "B", "C", "D"}[opcao] + " - " + Alternativas[opcao]);
        Console.SetCursorPosition(0, Console.CursorTop + 4 - opcao);
        return acerto;
    }
}