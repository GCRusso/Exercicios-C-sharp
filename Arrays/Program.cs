//e possivel criar um array como string,char,int e etc. qualquer forma ele ira funcionar.

//string[] carros = new string[3]; Desta forma voce esta especificando um tamanho para seu array de 3 valores AQUI NAO VALE A REGRA DO 0 
//tem que colocar a quantidade exata de quantas caixas voce deseja.
//se caso precisar adicionar um 4 valor nao sera possivel. ele deixa o espaco guardado mesmo que nao for utilizado todos os 3 valores.

//string[] carros = new string[]; Desta forma voce NAO esta especificando tamanho do array voce pode adicionar ou retirar algum valor.

//string[] cars = {"Volvo", "BMW", "Ford", "Mazda"}; Desta forma voce nao precisa especificar a NEW STRING pois ja esta com os valores apontados.




string[] carros = new string[3];
carros[0] = "Tesla";
carros[1] = "Maverick";
carros[2] = "Fusca";
Console.WriteLine($"Os carros cadastrado sao: {carros[0]}, {carros[1]} e {carros[2]}");
//e possivel alterar o nome de algum array a partir de um ponto do codigo como por exemplo:
carros[0] = "fusion";
//agora o carro [0] ira puxar o nome "Fusion"
Console.WriteLine($"o carro agora e {carros[0]}");





//Neste modo voce mostra toda a lista quando puxa a variavel "ITEM" e ele mostra todos os nomes que estao dentro da variavel "carros2"
// da para utilizar usando FOR para fazer a pergunta com Readline e abastecer a variavel ITEM exemplo abaixo.
string[] carros2 = {"tesla", "maverick", "fusca"};
foreach (var item in carros2)
{
    //colocando so esta variavel sera mostrado toda nossa lista
    Console.WriteLine($"{item}");
    
}



//Utilizando FOR para repetir o nosso array
string[] carros3 = new string[3];
// colocado o I < 3 pois menor q 3 e o 2 e o numero 0 sera contado no array 
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Informe o nome do carro: ");
    carros3[i] = Console.ReadLine();
        
}
Console.WriteLine($"Carros cadastrados com sucesso!");
for (int i = 0; i < length; i++)
{
    
}
Console.WriteLine($"Primeiro carro: {carros3[0]}");
Console.WriteLine($"Segundo carro: {carros3[1]}");
Console.WriteLine($"Terceiro carro: {carros3[2]}");













/*************EXEMPLO DO PROFESSOR*************/

/*//criar um array de strings para armazenar 3 carros
string[] carros = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Informe o nome do carro: ");    
    carros[i] = Console.ReadLine();    
}

Console.WriteLine($"Lista dos carros cadastrados: ");

// for (var i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Nome do carro: {carros[i]}");    
// }

foreach (var item in carros)
{
    Console.WriteLine(item);    
}*/