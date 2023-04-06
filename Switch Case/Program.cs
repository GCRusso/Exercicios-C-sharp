/*Console.WriteLine($"informe o numero correspondente da semana: ");
int diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana)
{
    case 1:
        Console.WriteLine($"Hoje e domingo!");
        break;
    case 2:
        Console.WriteLine($"Hoje e segunda!");
        break;
    case 3:
        Console.WriteLine($"Hoje e terca!");
        break;
    case 4:
        Console.WriteLine($"Hoje e quarta!");
        break;
    case 5:
        Console.WriteLine($"Hoje e quinta!");
        break;
    case 6:
        Console.WriteLine($"Hoje e sexta!");
        break;
    case 7:
        Console.WriteLine($"Hoje e sabado!");
        break;
    default:
        Console.WriteLine($"o dia informado nao corresponde a nenhum dia da semana.");
        break;
}*/


// PROGRAMA DE CALCULADORA USANDO SWITCH CASE

// LOGICA DA CALCULADORA
// 1 - informar a operacao
// 2 - informar o primeiro numero
// 3 - informar o segundo numero 
// 4 - fazer o calculo 
// 5 - exibir o resultado

//ENTRADA
//informado a operacao
Console.WriteLine(@$"
------------------------------------------------------------
                        CALCULADORA


    Informe os seguintes caracteres para realizar as operacoes:
        '+' para somar
        '-' para subtrair
        '*' para multiplicar
        '/' para dividir
");

Console.WriteLine($"Informe a operacao matematica desejada: ");
char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"Informe o primeiro numero: ");
float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo numero: ");
float numero2 = float.Parse(Console.ReadLine());

//Define a variavel que recebera o resultado
float resultado = 0;

//PROCESSAMENTO

switch (operacao)
{
    case '+':
    resultado = (numero1 + numero2);
    Console.WriteLine($"O Resultado da soma e de: {resultado}");
        break;
    case '-':
    resultado = (numero1 - numero2);
    Console.WriteLine($"O Resultado da subtracao e de: {resultado}");
        break;
    case '*':
    resultado = (numero1 * numero2);
    Console.WriteLine($"O Resultado da multiplicacao e de: {resultado}");
        break;
    case '/':
    resultado = (numero1 / numero2);
    Console.WriteLine($"O Resultado da divisao e de: {resultado}");
        break;

    default:
    Console.WriteLine($"a operacao informada nao e suportada em nossa calculadora! :( ");
        break;
}




