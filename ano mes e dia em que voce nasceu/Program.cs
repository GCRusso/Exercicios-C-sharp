Console.WriteLine($"Qual o dia em que você nasceu?: ");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual o mês em que você nasceu?: ");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual o ano em que você nasceu?: ");
int ano = int.Parse(Console.ReadLine());


 
if (dia > 31 )
{
Console.WriteLine($"Data Invalida! coloque entre 1 e 31." );

if (mes > 12)
Console.WriteLine($"Mes Invalido! Coloque entre 1 e 12." );

}

else if (ano > 2013)
Console.WriteLine($"Ano invalido! Coloque abaixo do ano em que estamos!" );

else {
    Console.WriteLine($"Você nasceu no dia {dia}, no mês {mes} e ano {ano} ");
    
}
