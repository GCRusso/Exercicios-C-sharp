/*Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
O sistema deve exibir um menu com as seguintes opções:

1- Cadastrar passagem
2- Listar Passagens
0- Sair


Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).


1- acesso ao sistema SENHA
2- cadastrar nome,origem, destino e data 5 passageiros
3- menu
4- cadastrar uma nova passagem? ou nao.*/

//Senha para acesso ao app
Console.WriteLine($"Digite a senha: ");
string senha = Console.ReadLine();

while (senha != "123456")
{
    Console.WriteLine($"Tente novamente: ");
    senha = Console.ReadLine();     
}
Console.WriteLine($"Acesso Liberado! ");

//
string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

//DEPOIS FAZER QUANTIDADE DE PASSAGEIROS.
Console.WriteLine($"Quanto passageiros vao embarcar?");
int quantidade = int.Parse(Console.ReadLine());

for (var i = 0; i < nome.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome do passageiro: ");
    nome[i] = Console.ReadLine();    
    Console.WriteLine($"Informe a origem do {i + 1}º passageiro: ");
    origem[i] = Console.ReadLine();    
    Console.WriteLine($"Informe o destino do {i + 1}º passageiro: ");
    destino[i] = Console.ReadLine();    
    Console.WriteLine($"Informe a data do voo do {i + 1}º passageiro: ");
    data[i] = Console.ReadLine();    
}