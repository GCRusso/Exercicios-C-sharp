
// importar as classes
using POO_Calculadora___exemplo_professor;

// Desenhar o menu

Console.WriteLine($"*** Programa Calculadora ***");
Console.WriteLine();

// instancia a classe calculadora
Calculadora calc = new Calculadora();

Console.Write($"Digite o primeiro número: ");
calc.n1 = float.Parse( Console.ReadLine() );

Console.Write($"Digite o segundo número: ");
calc.n2 = float.Parse( Console.ReadLine() );

Console.WriteLine(@$"
    Escolha a Operação

    1) Soma
    2) Subtração
    3) Multiplicação
    4) Divisão
    
    0) Sair
");
string opcao = Console.ReadLine();

switch ( opcao )
{
     case "0"://sair
        Console.WriteLine($"Obrigado por utilizar o programa, volte sempre");
        break;
     case "1"://soma
        Console.WriteLine($"Resultado da soma é: {calc.Somar()}");
        break;
     case "2"://subtração
        Console.WriteLine($"Resultado da subtração é: {calc.Subtrair()}");
        break;
     case "3"://multiplicação
        Console.WriteLine($"Resultado da multiplicação é: {calc.Multiplicar()}");
        break;
     case "4"://divisão
        Console.WriteLine($"Resultado da divisão é: {calc.Dividir()}");
        break;
     
    default:
        Console.WriteLine($"Opção Invlálida");
        break;
}
