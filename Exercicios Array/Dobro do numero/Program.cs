//criar um programa em c# que receba 5 numeros inteiros e ao final exiba o seu dobro
//voce deve utilizar a estrutura array com tamanho 5 para o armazenamento dos numeros, a estrutura
//FOR para a leitura dos numero e a estrutura FOREACH para exibilos


//entrada
    //criar o array tamanho 5

    int[] numeros = new int[5];

//processamento
    //Receber os numeros FOR
    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine($"Informe o numero {i + 1}º desejado: ");
        numeros[i] = int.Parse(Console.ReadLine());
         
    }

//saida
    //exibir os numeros com Foreach
    foreach (var item in numeros)   
    {
        Console.WriteLine($"seus numeros sao {item} o dobro dos numeros e {item * 2}");
    }