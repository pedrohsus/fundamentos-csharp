static int LerIdadeValida()
{
    int idade;
    bool idadeValida;

    do
    {
        Console.WriteLine("Digite sua idade: ");
        string input = Console.ReadLine();
        idadeValida = int.TryParse(input, out idade);

        if (!idadeValida)
        {
            Console.WriteLine("Entrada inválida.");
        }
    } while (!idadeValida);

    return idade;
}

static bool EhMaiorDeIdade(int idade)
{
    return idade >= 18;
}

int idade = LerIdadeValida();

if (EhMaiorDeIdade(idade))
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Menor de idade");
}