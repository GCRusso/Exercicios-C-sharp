////Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));


Console.WriteLine($"Informe seu nome: ");
string nome = Console.ReadLine();

while (nome.Length < 2 )
{
    Console.WriteLine($"Seu nome nao pode ter menos que 2 caracteres, por favor digite um nome valido!: ");
    nome = Console.ReadLine();
    
}

Console.WriteLine($"Informe sua idade: ");
int idade = int.Parse (Console.ReadLine());

while(idade <= 0 || idade > 101){
Console.WriteLine($"Insira uma idade valida entre 1 e 101 anos: ");
idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Informe seu salario: ");
float salario = float.Parse(Console.ReadLine());

while(salario < 0.01f)
{
    Console.WriteLine($"Insira um salario acima de R$0,01");
    salario = int.Parse(Console.ReadLine());
}


Console.WriteLine($"Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)) e 'd'(divorciado(a) ");
Console.WriteLine($"Digite seu estado civil com apenas uma letra: ");
char civil = char.Parse(Console.ReadLine());

while(!(civil == 's' || civil == 'c' || civil == 'v' || civil == 'd'))
{
    Console.WriteLine($"Digite apenas as letras informadas para cada estado civil: ");
    civil = char.Parse(Console.ReadLine());
}

Console.WriteLine($"Voce finalizou as questoes, muito obrigado! :) ");




