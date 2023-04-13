/*2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
Álcool:
. até 20 litros, desconto de 3% por litro Álcool
. acima de 20 litros, desconto de 5% por litro
Gasolina:
. até 20 litros, desconto de 4% por litro Gasolina
. acima de 20 litros, desconto de 6% por litro

Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
Dica: utilize switch case e funções/métodos para otimizar o algorítimo.*/

/*
- o que deseja abastecer? G- gasolina A- alcool OK 
- quantos litros deseja abastecer? OK
- avaliar o desconto (se caso tiver) 
- calcular o valor que sera pago
- mostrar o valor que sera pago pelo cliente
*/
Console.WriteLine(@$"
                            *****Posto Estrela do amanha*****
                                    
                                     PRECOS E DESCONTOS!
Gasolina - R$ 5,30 por litro
até 20 litros, desconto de 4% por litro Gasolina. acima de 20 litros, desconto de 6% por litro.

Alcool - R$ 4,90 por litro
até 20 litros, desconto de 3% por litro Álcool. acima de 20 litros, desconto de 5% por litro

digite a letra respectiva ao combustivel que deseja:
G - Gasolina
A - Alcool
");

Console.WriteLine($"Qual combustivel deseja abastecer?: ");
char combustivel = char.Parse(Console.ReadLine().ToLower());

switch (combustivel)
{
    case 'g':
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Voce selecionou GASOLINA!");
        Console.ResetColor();
        break;

    case 'a':
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Voce selecionou ALCOOL!");
        Console.ResetColor();
        break;

    default:
        do
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Voce nos informou um combustivel INVALIDO, por favor tente novamente!: ");
            Console.ResetColor();
            combustivel = char.Parse(Console.ReadLine().ToLower());
        }

        while (combustivel != 'g' && combustivel != 'a' && combustivel != 'A' && combustivel != 'G');
        {
            switch (combustivel)
            {

                case 'g':
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Voce selecionou GASOLINA!");
                    Console.ResetColor();
                    break;

                case 'a':
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Voce selecionou ALCOOL!");
                    Console.ResetColor();
                    break;
            }
        }
        break;
            Console.WriteLine($"Agora selecione quantos litros voce deseja abastecer?: ");
            int litros = int.Parse(Console.ReadLine());


        
}
