/*6. Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

Exemplo: tabuada do 1, tabuada do 2, etc...
Dica: utilize um laço dentro do outro.*/
Console.WriteLine($"Qual tabuada deseja que o programa execute? :");
int tabuada = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
    
}