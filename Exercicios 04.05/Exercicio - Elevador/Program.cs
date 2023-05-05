/*1.Crie uma classe denominada Elevador para armazenar as informações de um elevador
dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
presentes nele. A classe deve também disponibilizar os seguintes métodos:
Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
andares no prédio (os elevadores sempre começam no térreo e vazio);
Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
espaço);
Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
dentro dele);
Subir : para subir um andar (não deve subir se já estiver no último andar);
Descer : para descer um andar (não deve descer se já estiver no térreo);
Encapsular todos os atributos da classe (criar os métodos set e get).
*/
using Exercicio___Elevador;

Elevador eleve = new Elevador();
Console.WriteLine(eleve.Inicializa());

do
{
Console.WriteLine(@$"

1- Entrar
2- Sair
3- Subir
4- Descer
5- Mostrar Dados
");
string opcao = Console.ReadLine();
    
switch (opcao)
{
    case "1":
    eleve.Entrar();
        break;

    case "2":
    eleve.Sair();
        break;

    case "3":
    eleve.Subir();
        break;

    case "4":
    eleve.Descer();
        break;

    case "5":
    Console.WriteLine(@$"
    Quantidade de pessoas: {eleve.pessoas}
    {eleve.andares}º Andar
    ");
    
        break;

    default:
    Console.WriteLine($"Opcao invalida!");
        break;
}

} while (true);
 


