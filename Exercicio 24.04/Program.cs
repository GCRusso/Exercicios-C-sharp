//pegar os dados do aluno Nome, Curso, Idade, RG, media final(nao precisa efetuar calculo) e valor da mensalidade 
//teremos 2 metodos VerMediaFinal() e VerMensalidade() caso seja bolsista faremos o calculo 
// media maior ou igual a 8 = 50% de desconto
// media maior que 6 e menor que 8 = 30% de desconto
//media menor ou igual a 6 = valor integral.
//criar menu: visualizar media ou valor da mensalidade

using Exercicio_24._04;

char escolha = '0';
Alunos a = new Alunos();

a.Cadastro();

do
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(@$"
Seleciona a opcao que deseja realizar

1- Visualizar a nota media
2- visualizar a mensalidade

0- Sair
");
    Console.ResetColor();
    escolha = char.Parse(Console.ReadLine());

    switch (escolha)
    {
        case '1':
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Nota media do aluno: {a.VerMediaFinal()}");
            Console.ResetColor();
            break;
        case '2':
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Valor mensalidade: R${a.VerMensalidade()}");
            Console.ResetColor();
            break;
        case '0':
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Obrigado por utilizar nossa ferramenta!");
            Console.ResetColor();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção invalida!!");
            Console.ResetColor();
            break;
    }
} while (escolha != '0');

