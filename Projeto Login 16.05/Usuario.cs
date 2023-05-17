namespace Projeto_Login_16._05
{
    public class Usuario
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastroUsuario { get; private set; } = DateTime.Now;

        //Construtor aqui vai todos os metodos que serao utilizado para o login
        public Usuario()
        {
            Cadastrar();
        }
        public void Cadastrar()
        {
            Console.WriteLine($"Cadastrado de novo usuário");
            Console.WriteLine($"");
            this.Nome = "Gabriel";
            this.Email = "gabriel";
            this.Senha = "123";
            //this.DataCadastroUsuario = DateTime.Now;

            /*Console.WriteLine($"Código: ");
            Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine($"Email: ");
            Email = Console.ReadLine();
            Console.WriteLine($"Senha: ");
            Senha = Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"Cadastro concluído.");*/
        }
        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            //para zerar o datetime é utilizado esta mascara 
            this.DataCadastroUsuario = DateTime.Parse("0000-00-00T00:00:00");

        }

    }
}