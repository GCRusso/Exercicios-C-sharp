namespace Projeto_Login_16._05
{
    public class Login
    {
        public bool Logado { get; set; }
        // public string Usuario { get; set;}
        // public string Senha { get; set;}

        //aqui é para encaixar todos os métodos e chamar apenas o método Login na program.
        public Login(bool logado)
        {
            Usuario user = new Usuario();
            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {
            Console.WriteLine($"Email: ");
            string Email = Console.ReadLine();

            Console.WriteLine($"Senha: ");
            string Senha = Console.ReadLine();

            if (Email == usuario.Email && Senha == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login Efetuado");
            }

            else
            {
                this.Logado = false;
                Console.WriteLine($"Usuário ou Senha incorreta!");
            }
        }
        public string Deslogar()
        {
            return "";
        }
        public void login()
        {

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
                        Console.WriteLine($"Informe o codigo para ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        // produto.DeletarProduto(codigoProduto);
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
                        Console.WriteLine($"Saindo...");

                        break;
                    default:
                        Console.WriteLine($"tente novamente:");

                        break;
                }
            } while (opcao != "0");

        }
    }
}