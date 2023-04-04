//Condicional Simples
//Executa uma ou mais ações se a condição for verdadeira
//condição : se o sol é true

// bool sol = false;

// if (sol)
// {
//     Console.WriteLine($"Vou para a praia !");    
// }

// //Condicional Composta
// bool sol = false;

// if (sol)
// {
//     Console.WriteLine($"Vou para a praia!");    
// }
// else
// {
//     Console.WriteLine($"Vou é dormir zzzz!");    
// }


// //Condicional Composta
// bool sol = true;
// bool folga = false;

// if (sol && folga )
// {
//     Console.WriteLine($"Vou para a praia!");    
// }
// else
// {
//     Console.WriteLine($"Vou é trabalhar!");    
// }

// int x = 2;
// int y = 3;

// if (x == y)
// {
//     Console.WriteLine($"São iguais");    
// }
// else
// {
//     Console.WriteLine($"São diferentes");    
// }

// //operador ternário
// //               condição verdade ? senão : false
// string eIgual =  (x == y) ? "São iguais" : "São diferentes";
// Console.WriteLine(eIgual);

// //condicional encadeada

// //maior ou igual a 18 : pode entrar na festa
// //maior ou igual de 16 menor que 18 : pode entrar com responsável
// //menor do que 16 : não pode entrar

// int idade = 18;

// if (idade >= 18)
// {
//     Console.WriteLine($"Pode entrar na festa!");    
// }
// else if (idade >= 16 && idade < 18)
// {
//     Console.WriteLine($"Pode entrar na festa com a mamãe!");    
// }
// else
// {
//     Console.WriteLine($"Não pode entrar, proibido para criancinhas!");    
// }









//operador tenario// condicao verdade ? senao : false
//string eIgual = ( x==y ) ? "sao iguais" : "sao diferentes";
//Console.WriteLine(eIgual);






//condicional encadeada
//maior ou igual a 18 : pode entrar na festa
//maior ou igual de 16 anos : pode entrar com responsavel
//menor do que 16 : nao pode entrar na festa

Console.WriteLine($"Digite sua idade:  ");
int idade = int.Parse(Console.ReadLine()) ;

if (idade >= 18)
{
    Console.WriteLine($"pode entrar na festa");
    
}

else if ( idade >= 16 && idade < 18)
{
    Console.WriteLine($"pode entrar com responsavel");
    
}

else
{
Console.WriteLine($"nao pode entrar na festa");

}
