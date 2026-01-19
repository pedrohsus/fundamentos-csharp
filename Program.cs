Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual a sua idade?");
string inputIdade = Console.ReadLine();

bool idadeValida = int.TryParse(inputIdade, out int idade);

if (!idadeValida)
{
    Console.WriteLine("Idade inválida. Digite apenas números.");
    return;
}

if (idade >= 18)
{
    Console.WriteLine($"Olá, {nome}. Você tem {idade} anos. Você é maior de idade!");
}
else
{
    Console.WriteLine($"Olá, {nome}. Você tem {idade} anos. Você é menor de idade!");
}