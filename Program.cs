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
            Console.WriteLine("Entrada inválida.");

    } while (!idadeValida);

    return idade;
}

int idade = LerIdadeValida();
var pessoa = new Pessoa(idade);

var resultado = pessoa.ValidarIdade();

if (!resultado.Sucesso)
    Console.WriteLine(resultado.Erro);
else
    Console.WriteLine("Pessoa válida e maior de idade.");