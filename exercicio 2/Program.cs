
// o maior, menor e o numero esta = 0, so para criar a variavel poderia utilizar qualquer numero que seria o mesmo efeito. TL = 4 pois informa a quantidade de vezes que ira fazer o loop do codigo no caso 4 vezes.

int maior = 0, menor = 0, i = 0, numero = 0, tl = 10;

//cria a primeira inserção de numero do usuario
Console.WriteLine($"Informe o 1 número: ");
numero = int.Parse (Console.ReadLine());
maior = numero;
menor = numero;
// o i esta representando nosso contador, aqui esta avisando que ja recebemos o primeiro numero.
i = 1;

//o i (contador) aqui ja esta em 2 pois sera o segundo codigo, <=tl é o valor que foi mencionado de quantas vezes sera o loop q no caso foi 4vezes pois sera 4 numeros, i++ é o incremento do contador, estamos em 2 o proximo sera 3 e depois 4 que chega ao fim do loop.
for (i= 2; i <= tl; i++)
{
    //o contador aqui nos ajuda a alterar a nossa frase para o usuario, pedindo para informar o 1,2,3 e 4.
    Console.WriteLine($"Informe o " + i + " número: ");
    numero = int.Parse (Console.ReadLine());

    // se o numero que usuario informou for menor que meu atual menor, o meu atual menor recebera o valor de "numero"
    if (numero < menor)
    {
        menor = numero;
    }

    // se o numero que o usuario informou for maior que meu atual maior, o meu atual maior recebera o valor de "numero"
    if (numero > maior)
    {
        maior = numero;
    }
}

//aqui forma a mensagem mostrando para o usuario qual foi o maior e o menor numero.
Console.WriteLine($"O maior número é: {maior}");
Console.WriteLine($"O menor número é: {menor}");





