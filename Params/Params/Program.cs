class Program
{
    static void Main()
    {
        var nome = "João";
        var nome2 = "Felipe";
        ImprimirNomes(nome, nome2);

        var nomes = new string[] { "Caio", "José", "Maria" };
        ImprimirNomes(nomes);

        Console.ReadKey();
    }

    static void ImprimirNomes(params string[] nomes)
    {
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}
