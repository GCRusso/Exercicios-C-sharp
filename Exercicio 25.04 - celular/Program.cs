/*Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
Só será possível executar tais métodos se o celular estiver ligado.
Envie o link do repositório como entrega desta atividade.

1- propriedades da classe - cor, modelo e tamanho
3- se estiver ligado
2- metodos - ligar, desligar, fazer ligação e enviar mensagem 
*/

using Exercicio_25._04___celular;

Celular a = new Celular();

a.CadastroCelular();

Console.WriteLine(@$"
Funções do celular
1- Ligar o celular
2- Desligar o celular

0- Sair
");
char opcao = char.Parse(Console.ReadLine());

switch (opcao)
{
    case '1':
        break;

    case '2':
        break;

    default:
        break;
}


