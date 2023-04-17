//************************** WHILE ***********************************

esse codigo ira se repetir ate o ASD ser igual a 10, entao criara 10 linhas.
int asd = 1;
while (asd <= 10)
{
    Console.WriteLine($"{asd}");
    asd++;
}

//o codigo ira se repetir ate acertar quantos anos tem o pericles, ate se tornar TRUE a idade.
bool idadeCerta = false;

while (idadeCerta == false)
{
    Console.WriteLine($"Qual a idade do Pericles? ");
    int idade = int.Parse(Console.ReadLine());

    if (idade == 53)
    {
        idadeCerta = true;
        Console.WriteLine($"voce acertou a idade do Pericles!");
    }

}


//um programa que receba o nome do usuario e a senha ok
//a senha deve ter 6 caracteres ex: "admin@" ok 
//validar a senha
//enquanto a senha nao estiver com regra pedida, preciso que 
//o programa nao se encerra e que solicite que seja digitado
//uma senha no padrao requerido
//caso a senha informada esteja com 6 caracteres, exiba uma mensagem de ok

Console.WriteLine($"digite o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"digite a sua senha (tem que ter 6 caracteres)");
string senha = Console.ReadLine();

while (senha != "123456")
{
    Console.WriteLine($"Digite uma senha no padrão requerido (com 6 caracteres): ");
    senha = Console.ReadLine();     
}
Console.WriteLine($"Usuário e senha recebidas com sucesso!");






//*********************** DUO WHILE ********************
int i = 0;
do{
    Console.WriteLine(i); //exibe o valor de i = 6
    i++; //incrementa mais 1
    Console.WriteLine(i); // mostra o novo valor de i =7

}

while(i < 5);



//o codigo ira se repetir ate acertar quantos anos tem o pericles, ate se tornar TRUE a idade.
int idadeCerta = 0;

do{
    Console.WriteLine($"Qual a idade do Pericles? ");
    idadeCerta++;
    Console.WriteLine($"A idade do Pericles e de {idadeCerta}?");
}
while (idadeCerta != 53);

Console.WriteLine($"Voce acertou {idadeCerta}");


//********************************* FOR *********************************
// mostra de 2 em 2 o codigo se repete ate ser true
for (int t = 0; t <=50; t+=2)
{
    Console.WriteLine(t);
}