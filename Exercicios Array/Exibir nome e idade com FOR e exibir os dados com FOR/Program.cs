//escreva um programa que receba e imprima o nome e idade de 5 pessoas

//exemplo:
//nome: carlos
//idade: 36 anos

string[] nome = new string[5];
int[] idade = new int[5];

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome:");
    nome[i] = Console.ReadLine().ToLower();

    Console.WriteLine($"Informe a {i + 1}º idade: ");
    idade[i] = int.Parse(Console.ReadLine());

}

for (var i = 0; i < 5; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{i + 1} ) Nome: {nome[i]}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($@"    Idade: {idade[i]}");
    Console.ResetColor();
}

