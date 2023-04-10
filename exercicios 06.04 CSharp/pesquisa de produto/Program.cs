/*
1. Uma certa empresa fez uma
pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
A.    
O número de pessoas que responderam SIM.

B.    
O número de pessoas que responderam NÃO;

C.   
O número de mulheres que responderam SIM;

D.   
A porcentagem de homens que responderam NÃO entre todos

E.    
os homens analisados.
*/
// coletar o sexo 
//coletar as informacoes dos clientes os SIM E NAO
//
int i = 0, tl = 10;
int mulher = 0, homem = 0, sim = 0, nao = 0, mulhersim = 0, homemTotal= 0, homemNao = 0;


int total = homem + mulher;

Console.WriteLine($@"
***********Pesquisa do novo anti-transpirante SUVACO***************

    Precisamos da opniao de 10 pessoas sobre o novo produto
        por favor nos ajude com a pesquisa a baixo!
-------------------------------------------------------------------
");
/*Estrutura do FOR
var i = 1; inicializador
i <= 3; Condicional
i++; incremento */
for (i = 1; i <= tl; i++)
{
    Console.WriteLine(@$"
Qual o seu sexo? 
Digite o numero respectivo ao seu sexo.

1 - Masculino 
2 - Feminino");
    int sexo = int.Parse(Console.ReadLine());

    switch (sexo)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sexo MASCULINO validado!");
            Console.ResetColor();
            homem++;
            break;
        case 2:
            mulher++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sexo FEMININO validado!");
            Console.ResetColor();
            break;

        default:
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERRO: NAO EXISTE ESTA OPCAO POR FAVOR DIGITE UM VALOR VALIDO!");
                Console.ResetColor();
                sexo = int.Parse(Console.ReadLine());
            }

            while (sexo != 1 && sexo != 2);

            break;
    }

    Console.WriteLine($@"
Voce gostou do novo anti-transpirante SUVACO?
Digite o numero respectivo da sua opniao.

1 - Sim
2 - Nao
");
    int opniao = int.Parse(Console.ReadLine());

    switch (opniao)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Resposta 'SIM' validada!");
            Console.ResetColor();
            sim++;
            break;
        case 2:
            nao++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Resposta 'NAO' validada!");
            Console.ResetColor();
            break;

        default:
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERRO: NAO EXISTE ESTA OPCAO POR FAVOR DIGITE UM VALOR VALIDO!");
                Console.ResetColor();
                opniao = int.Parse(Console.ReadLine());
            }

            while (opniao != 1 && opniao != 2);

            break;
            
    }
            if (sexo == 2 && opniao == 1){
                mulhersim++;
            }

            if(sexo == 1){
                homemTotal++;
            }

            if(sexo == 1 && opniao == 2)
            {
                homemNao++;
            }


}
//Porcentagem de homens que falaram nao entre todos os homens que participou da pesquisa
    double porcentagem = Math.Round(((double)homemNao/(double)homemTotal)* 100,2);

//Quantidade de respostas SIM E NAO
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Quantidade de respostas POSITIVAS: {sim}");
    Console.ResetColor();
    
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Quantidade de respostas NEGATIVAS: {nao}");
    Console.ResetColor();
    
//Quantidade de mulheres que responderam SIM
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Quantidade de mulheres que responderam POSITIVAMENTE: {mulhersim}");
    Console.ResetColor();
//Quantidade total de homens que participou da pesquisa
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Total de homens que participou da pesquisa: {homemTotal}");
    Console.ResetColor();

// Porcentagem dos homens que falaram que nao gostaram do produto
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"A porcentagem dos homens que responderam NEGATIVAMENTE: %{porcentagem}");
    Console.ResetColor();






