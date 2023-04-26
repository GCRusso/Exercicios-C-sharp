/*Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
Só será possível executar tais métodos se o celular estiver ligado.
Envie o link do repositório como entrega desta atividade.

1- propriedades da classe - cor, modelo e tamanho
3- se estiver ligado
2- metodos - ligar, desligar, fazer ligação e enviar mensagem 
*/

using Exercicio_25._04___celular;

Celular phone = new Celular();

phone.CadastroCelular();

phone.LigarCelular();
char opcao = '0';
do
{
    
Console.WriteLine(@$"
Funções do celular
1- Fazer ligacao
2- Enviar mensagem

0- Sair/Desligar
");
opcao = char.Parse(Console.ReadLine());

switch (opcao)
{
    case '1':
    phone.FazerLigacao();
        break;

    case '2':
    phone.EnviarMensagem();
        break;
    case '0':
    Console.WriteLine($"Desligando...");
        break;

    default:
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Voce digitou um numero invalido!");
    Console.ResetColor();
    
        break;
}
} while (opcao == '1' || opcao == '2' || opcao == '4');