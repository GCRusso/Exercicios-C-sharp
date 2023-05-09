/*3.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.

- metodo para imprimir dados do jogador
- metodo para calcular idade do jogador
- metodo de quanto tempo falta para se aposentar
- criar subclasse JOGADORDEFESA - 40 anos para aposentadoria
- criar subclasse JOGADORATAQUE -  35 anos para aposentadoria
- criar subclasse JOGADORMEIO-CAMPO - 38 anos para aposentadoria

*/
using Exercicio___Jogador;
JogadorAtaque ataque = new JogadorAtaque();
JogadorDefesa defesa = new JogadorDefesa();
JogadorMeioCampo meioCampo = new JogadorMeioCampo();


string posicao = "";
do
{

    Console.WriteLine(@$"
Cadastro de novo jogador

Qual a posição do jogador?
1- Atacante
2- Meio Campo
3- Zagueiro

0- Sair
");
    posicao = Console.ReadLine();


    switch (posicao)
    {
        case "1":
            Console.WriteLine($"Você selecionou como posição de: Atacante");
            ataque.CadastroJogador();
            ataque.AposentadoriaAtaque();
            break;

        case "2":
            Console.WriteLine($"Você selecionou como posição de: Meio Campo");
            meioCampo.CadastroJogador();
            meioCampo.AposentadoriaMeioCampo();
            break;

        case "3":
            Console.WriteLine($"Você selecionou como posição de: Zagueiro");
            defesa.CadastroJogador();
            defesa.AposentadoriaZagueiro();
            break;

        case "0":
            Console.WriteLine($"Saindo...");
            break;

        default:
            Console.WriteLine($"Opcao Inválida!");
            break;
    }
} while (posicao != "0");


