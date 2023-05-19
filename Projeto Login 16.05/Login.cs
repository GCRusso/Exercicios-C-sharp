namespace Projeto_Login_16._05
{
    public class Login
    {
        public bool Logado { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        //aqui é para encaixar todos os métodos e chamar apenas o método Login na program.
        public Login(bool logado)
        {
            Usuario user = new Usuario();
            Logar(user);

            if (Logado == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                GerarMenu();
                Console.ResetColor();
            }
        }

        public void Logar(Usuario usuario)
        {
            do
            {
                Console.WriteLine($"Email: ");
                string Email = Console.ReadLine();

                Console.WriteLine($"Senha: ");
                string Senha = Console.ReadLine();

                if (Email == usuario.Email && Senha == usuario.Senha)
                {
                    this.Logado = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"
                
                Login Efetuado");
                    Console.ResetColor();
                }

                else
                {
                    this.Logado = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@$"
                Email ou Senha incorreto!
                Tente novamente.");
                    Console.ResetColor();
                }
            } while (Logado == false);
        }
        public string Deslogar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return "Saindo do sistema...";
            Console.ResetColor();
        }

        public void GerarMenu()
        {
            string opcao = "";
            Produto produto = new Produto();
            Marca marca = new Marca();
            do
            {

                Console.WriteLine(@$"
                    MENU

            1- Cadastrar Produtos
            2- Listar Produtos
            3- Remover Produtos
            
            4- Cadastrar Marca
            5- Listar Marca
            6- Remover Marca

            0- Sair/Deslogar
            ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        produto.CadastrarProduto();
                        break;
                    case "2":
                        produto.ListarProduto();
                        break;
                    case "3":
                        produto.DeletarProduto();
                        break;
                    case "4":
                        marca.CadastrarMarca();
                        break;
                    case "5":
                        marca.ListarMarca();
                        break;
                    case "6":
                        marca.DeletarMarca();
                        break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Aplicativo encerrado!");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"");
                        Console.WriteLine($"Tente Novamente: ");
                        Console.ResetColor();
                        break;
                }
            } while (opcao != "0");

        }
    }
}