// CALCULADORA DE SOMA
static float Somar(float n1, float n2)
{
    return (n1 + n2);
}
Console.WriteLine($"*****Calculadora de SOMA*****");

Console.WriteLine($"Informe o primeiro numero: ");
float primeiroNumero = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo numero: ");
float segundoNumero = float.Parse(Console.ReadLine());

Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} e de : {Somar(primeiroNumero, segundoNumero)}");


//CALCULADORA DE SUBTRACAO
static float Subtracao(float n1, float n2)
{
    return (n1 - n2);
}
Console.WriteLine($"*****Calculadora de SUBTRACAO*****");

Console.WriteLine($"Informe o primeiro numero: ");
float primeiroNumero2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo numero: ");
float segundoNumero2 = float.Parse(Console.ReadLine());

Console.WriteLine($"A subtracao de {primeiroNumero2} - {segundoNumero2} e de : {Subtracao(primeiroNumero2, segundoNumero2)}");


//CALCULADORA DE MULTIPLICACAO

static float Multiplicacao(float n1, float n2)
{
    return (n1 * n2);
}
Console.WriteLine($"*****Calculadora de MULTIPLICACAO*****");

Console.WriteLine($"Informe o primeiro numero: ");
float primeiroNumero3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo numero: ");
float segundoNumero3 = float.Parse(Console.ReadLine());

Console.WriteLine($"A multiplicacao de {primeiroNumero3} * {segundoNumero3} = {Multiplicacao(primeiroNumero3, segundoNumero3)}");

//CALCULADORA DE DIVISAO

static float Divisao(float n1, float n2)
{
    return (n1 / n2);
    }

    Console.WriteLine($"*****Calculadora de DIVISAO*****");

    Console.WriteLine($"Informe o primeiro numero: ");
    float primeiroNumero4 = float.Parse(Console.ReadLine());

    Console.WriteLine($"Informe o segundo numero: ");
    float segundoNumero4 = float.Parse(Console.ReadLine());

    Console.WriteLine($"A divisao de {primeiroNumero4} / {segundoNumero4} = {Divisao(primeiroNumero4,segundoNumero4)}");
    
    
    
    