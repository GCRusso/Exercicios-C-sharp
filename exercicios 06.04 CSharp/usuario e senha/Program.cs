Console.WriteLine($"Digite o usuario: ");
string usuario = Console.ReadLine();

Console.WriteLine($"Digite a senha: ");
string senha = Console.ReadLine();


while(usuario == senha){
    Console.WriteLine($"A senha nao pode ser igual ao usuario por favor repita: ");
    senha = Console.ReadLine();
    
}

Console.WriteLine($"Senha cadastrada com sucesso! :) ");