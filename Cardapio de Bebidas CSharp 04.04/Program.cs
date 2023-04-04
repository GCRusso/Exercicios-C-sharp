Console.WriteLine(@$"
---------------------------------------------------------------------------------------------
|                            Bem vindo a lanchonete Switch!                                 |
|                                                                                           |
| Para escolher sua bebida de preferencia aperte os numeros de acordo com o produto.        |
|                                                                                           |
|            1 - Coca-Cola                                                                  |
|            2 - Fanta Laranja                                                              |
|            3 - Sprite                                                                     |
|            4 - Suco de Laranja                                                            |
|            5 - Chocolate Quente                                                           |
|            6 - Cafe                                                                       |
| Caso queira adicionar gelo a sua bebida responder com SIM ou NAO apos selecionar a bebida |
---------------------------------------------------------------------------------------------
");

Console.WriteLine($"Informe o numero da bebida desejada: ");
byte escolha = byte.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine($"Voce escolheu Coca-cola! ");
        break;
    case 2:
        Console.WriteLine($"Voce escolheu Fanta Laranja! ");
        break;
    case 3:
        Console.WriteLine($"Voce escolheu Sprite! ");
        break;
    case 4:
        Console.WriteLine($"Voce escolheu Suco de Laranja! ");
        break;
    case 5:
        Console.WriteLine($"Voce escolheu Chocolate Quente!: ");
        break;
    case 6:
        Console.WriteLine($"Voce escolheu Cafe!: ");
        break;
    default:
    Console.WriteLine($"Voce informou um valor que nao esta especificado em nosso cardapio, por favor repita o processo. :)");
        break;

}
//foi utilizado o ! para que a escolha 5 e a 6 nao de a opcao do gelo para o usuario. 
//funciona se voce NAO !=negacao escolher a opcao 5 e 6 ele faz a pergunta do gelo
if(!(escolha == 5 || escolha == 6 || escolha >= 6)){

Console.WriteLine($"Deseja adicionar gelo a sua bebida?: ");
string gelo = (Console.ReadLine().ToLower());
        
if (gelo == "sim"){
    Console.WriteLine($"Gelo adicionado com sucesso!");
}

else{
    Console.WriteLine($"Sem gelo na sua bebida!");
    }

}
























