static int LerIdadeValida()
{
    int idade;
    bool idadeValida;

    do
    {
        Console.WriteLine("Digite sua idade: ");
        string? input = Console.ReadLine();
        idadeValida = int.TryParse(input, out idade);

        if (!idadeValida)
        {
            Console.WriteLine("Entrada inválida.");
        }
    } while (!idadeValida);

    return idade;
}

int idade = LerIdadeValida();
Pessoa pessoa = new Pessoa(idade);

if (pessoa.IdadeForaDoIntervalo())
{
    Console.WriteLine("Idade fora do intervalo permitido (0 à 120).");
}
else if (pessoa.EhMaiorDeIdade())
{
    Console.WriteLine("Maior de idade.");
}
else
{
    Console.WriteLine("Menor de idade.");
}

class Pessoa
{
    public int Idade {get;}

    public Pessoa(int idade)
    {
        Idade = idade;
    }

    public bool IdadeForaDoIntervalo()
    {
        return Idade < 0 || Idade > 120;
    }

    public bool EhMaiorDeIdade()
    {
        return Idade >= 18;
    }
}