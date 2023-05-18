namespace Projeto_Login_16._05
{
    public class Usuario
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastroUsuario { get; private set; } = DateTime.Now;

        
        public Usuario()
        {
            Cadastrar();
        }
        public void Cadastrar()
        {
            Console.WriteLine($"Cadastrado De Novo Usuário");
            Console.WriteLine($"");
            Console.WriteLine($"Código de usuário: ");
            this.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o nome do usuario?: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine($"Email: ");
            this.Email = Console.ReadLine();
            Console.WriteLine($"Senha: ");
            this.Senha = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"");
            Console.WriteLine(@$"
            Cadastrado com sucesso!

            Nome: {Nome}
            Email: {Email}

            Data de Cadastro: {DataCadastroUsuario}
            ");
            Console.ResetColor();

        }

    }
}