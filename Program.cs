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

ResultadoValidacao resultado = pessoa.ValidarIdade();

if (!resultado.Sucesso)
{
    Console.WriteLine(resultado.Erro);
}
else
{
    Console.WriteLine("Pessoa válida e maior de idade.");
}

class Pessoa
{
    public int Idade {get;}

    public Pessoa(int idade)
    {
        Idade = idade;
    }

    public ResultadoValidacao ValidarIdade()
    {
        if (Idade < 0 || Idade > 120)
        {
            return ResultadoValidacao.Falha("Idade fora do intervalo permitido (0 a 120).");
        }

        if (Idade < 18)
        {
            return ResultadoValidacao.Falha("Pessoa menor de idade.");
        }

        return ResultadoValidacao.Ok();
    }
}

class ResultadoValidacao
{
    public bool Sucesso {get;}
    public string? Erro {get;}

    private ResultadoValidacao(bool sucesso, string? erro)
    {
        Sucesso = sucesso;
        Erro = erro;
    }

    public static ResultadoValidacao Ok()
    {
        return new ResultadoValidacao(true, null);
    }

    public static ResultadoValidacao Falha(string erro)
    {
        return new ResultadoValidacao(false, erro);
    }
}