/*
2.Você trabalha em uma empresa especialista em máquinas de fazer café e sua equipe é a responsável por desenvolver uma classe para o novo modelo de cafeteiras que irão fabricar.

No modelo anterior das cafeteiras, os usuários podiam selecionar se era para ser adicionado açúcar ou não, mas a nova versão da Super CafeteiraTabajaras Plus++ deve ser capaz de receber a quantidade (em gramas) de açúcar a ser colocada no café. Mesmo com essa nova possibilidade, o usuário não será obrigado a informar quanto de açúcar deseja. Deve-se adicionar 10 gramas de açúcar por padrão caso nenhum valor seja informado.

a. Para começar, crie a classe "MaquinaCafe" com um atributo chamado "acucarDisponivel", que será útil para saber a quantidade de açúcar disponível na máquina. Se o açúcar acabar, a máquina só permitirá cafezinhos sem açúcar, certo?

b. Agora crie um método chamado "fazerCafe" na mesma classe. Esse método deve verificar se a quantidade de açúcar disponível na máquina é suficiente e, claro, fazer o café.

c. Como o usuário não será obrigado a informar a quantidade de açúcar a ser adicionado no café, crie outro método com o nome "fazerCafe", que não recebe nenhum parâmetro. Isso é uma sobrecarga de métodos!
*/
using Exercicio___Maquina_de_Cafe;

MaquinaCafe cafeteria = new MaquinaCafe();
int acucar = 0;

string opcao = "";

do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"
    Cafeteira Tabajaras Plus++

1- Cafe com açucar padrão (10 gramas)
2- Cafe com açucar personalizado
3- Açucar disponível na máquina

0- Cancelar pedido
");
    Console.ResetColor();
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            cafeteria.FazerCafe();
            break;

        case "2":
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Adicione a quantidade de açucar em gramas: ");
            Console.ResetColor();
            bool confirmacaoAcucar = int.TryParse(Console.ReadLine(), out acucar);
            if (confirmacaoAcucar == false)
            {
                cafeteria.FazerCafe();
            }

            else
            {
                cafeteria.FazerCafe(acucar);
            }
            break;

        case "3":
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Temos {cafeteria.acucarDisponivel} gramas de açucar disponível");
            Console.ResetColor();
            break;

        case "0":
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Pedido cancelado!");
            Console.ResetColor();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção Inválida!");
            Console.ResetColor();
            break;
    }
} while (opcao != "0");

