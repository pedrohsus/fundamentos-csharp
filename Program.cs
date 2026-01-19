Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

int idade = 0;
bool idadeValida = false;

while (!idadeValida)
{
    Console.WriteLine("Qual a sua idade?");
    string inputIdade = Console.ReadLine();

    idadeValida = int.TryParse(inputIdade, out idade);

    if (!idadeValida)
    {
        Console.WriteLine("Idade inválida. Digite apenas números.");
    }
}

if (idade >= 18)
{
    Console.WriteLine($"Olá, {nome}. Você tem {idade} anos. Você é maior de idade!");
}
else
{
    Console.WriteLine($"Olá, {nome}. Você tem {idade} anos. Você é menor de idade!");
}