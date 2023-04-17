/*5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.*/

for (var i = 1; i <= 10; i++)
{
    Console.WriteLine($"Tabuada do {i}: ");
    
    for (int a = 0; a <= 10; a++)
    {
       Console.WriteLine($"{i} X {a} = {i * a} ");
    }

}