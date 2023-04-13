//Funcoes - cria uma funcao para repeticao de codigos que sao utilizados frequentemente.

//MyMethod = E utilizado a PascalCase.
//static = significa que o metodo pertence a classe program e nao um objeto da classe program.
//void = nao tem valor de retorno

//static = pq o metodo esta dentro da classe Program.cs
//void = tipo de retorno (neste caso sem retorno)
//MyMethod()= nome do metodo (usar PascalCase)
//Exemplo: 
//static void MyMethod()
{
//INSERIR O BLOCO DE CODIGO
}

// EXEMPLO DE RETORNO VOID (NO CASO SEM RETORNO)

 static void SaudacaoTerraqueos()
 {
     Console.WriteLine($"Informe o nome: ");
string nome = Console.ReadLine();

     Console.WriteLine($"Informe o sobrenome:");
 string sobrenome = Console.ReadLine();

 Console.WriteLine($"Bom dia, {nome} {sobrenome}!!");

 }
// //Chama o bloco de codigo a ser executada em qualquer lugar do seu codigo em qualquer funcao.
 SaudacaoTerraqueos();








//EXEMPLO DE RETORNO SOMAR! EXEMPLO 2

//criar um metodo para somar 2 numeros
//e obrigatorio colocar 2 numeros e o "return" 
//e criado uma funcao para agilizar o processo de soma so chamando o SOMAR em frente aos numeros
static float Somar(float n1, float n2)
 {
 return (n1 + n2);
 }

 Console.WriteLine($"Informe o primeiro numero: ");
 float primeiroNumero = float.Parse(Console.ReadLine());

 Console.WriteLine($"Informe o segundo numero: ");
 float segundoNumero = float.Parse(Console.ReadLine());

 /*aqui voce ve em acao a funcao, temos o recebimento do valor primeiroNumero e do segundoNumero e na frente e utilizado
 a funcao Somar desta forma que e aplicada no exemplo.*/
 Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} e de : {Somar(primeiroNumero,segundoNumero)}");






//EXEMPLO 3

//metodo para trazer a hora do sistema
/*
static int MostrarHora(){
    return(DateTime.Now.Hour);
}
Console.WriteLine(MostrarHora());*/





//EXEMPLO 4 

static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
{
    Console.Write($"{texto}");

    for (var i = 0; i < quantidadePontinhos; i++)
    {
        //apenas no console WRITE para sair um do lado do outro
        Console.Write($".");
        Thread.Sleep(tempo);
    }
    
}
//aqui ira mostrar o texto=carregando depois int=quantidadePontinhos e por ultimo o tempo em milisegundos=1000
BarraCarregamento("Carregando",25,100);
BarraCarregamento("Aguarde",50,100);
BarraCarregamento("Quase Pronto",10,100);




//EXEMPLO 5 

static string MyName(String nome)
{
    return ("");
}

MyName();