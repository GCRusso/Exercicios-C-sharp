
using POO_Calculadora;
Calculadora a = new Calculadora();

Console.WriteLine(@$"
*****Bem Vindo a Calculadora*****

seleciona a operacao

1- Soma
2- Subtrair
3- Multiplicacao
4- Divisao

0- Sair
");
int escolha = int.Parse(Console.ReadLine());
do
{
    
switch (escolha)
{
    case 1:
        a.Soma();
        break;
    case 2:
        a.Subtracao();
        break;
    case 3:
        a.Multiplicacao();
        break;
    case 4:
        a.Divisao();
        break;
    case 0:
        Console.WriteLine($"Obrigado por utilizar nosso programa!");
        break;
    default:
        Console.WriteLine($"Digite um numero valido!");
        escolha =int.Parse (Console.ReadLine());
        
    
        break;
}

} while (escolha < 0 || escolha > 4);
