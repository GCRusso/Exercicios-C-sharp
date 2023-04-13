/*1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).*/
//informe a idade
//calcular idade
//idade minima para votar 16 anos
//Posso votar? sim ou nao

static int CalcularAno(int ano)
{
return (DateTime.Now.Year - ano - 1);
}

Console.WriteLine($"Informe o ano do nascimento: ");
int ano = int.Parse(Console.ReadLine());

int idadeAnos = CalcularAno(ano);

Console.WriteLine($"Sua idade e de: {idadeAnos} anos.");

if(idadeAnos <= 15)
{
    Console.WriteLine($"Voce ainda nao tem a idade permitida para votar!");
    
}

else
{
    Console.WriteLine($"Voce ja pode votar!");
    
}



