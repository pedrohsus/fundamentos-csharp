Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual a sua idade?");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Olá, {nome}. Você tem {idade} anos.");