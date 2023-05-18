namespace Projeto_Login_16._05
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataProduto { get; private set; } = DateTime.Now;
        public Usuario cadastradoPor { get; private set; }
        public Marca marquinha {get; set;}

        List<Produto> listaDeProdutos = new List<Produto>();
        public Produto()
        {

        }
        public Produto(int _codigoProduto, string _nomeProduto, float _preco)
        {
            Codigo = _codigoProduto;
            Nome = _nomeProduto;
            Preco = _preco;
        }
        public void CadastrarProduto()
        {
            Marca CadastrarMarcaProdutos = new Marca();

            Console.WriteLine($"Qual o código do produto?: ");
            int CodigoProduto = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o nome do produto?: ");
            string NomeProduto = Console.ReadLine();
            Console.WriteLine($"Qual o valor do produto?: ");
            float PrecoProduto = float.Parse(Console.ReadLine());
            
            marquinha = CadastrarMarcaProdutos.CadastrarMarca();
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@$"
            Produto cadastrado com sucesso!
            
            Código do Produto: {CodigoProduto}
            Nome do Produto: {NomeProduto}
            Preço do Produto: {PrecoProduto}
            Marca do Produto: {marquinha.Nome}

            Cadastrado Por: 
            Data de Cadastro: {DataProduto}
            ");
            Console.ResetColor();

            //Adicionando produto na lista de produtos
            listaDeProdutos.Add(new Produto(CodigoProduto, NomeProduto, PrecoProduto));

        }

        public void ListarProduto()
        {
            Marca IdentificadorMarca = new Marca();
            Usuario usuariocadastro = new Usuario();

            foreach (var item in listaDeProdutos)
            {
                Console.WriteLine(@$"
    Código: {item.Codigo} 
    Nome: {item.Nome} 
    Preço: {item.Preco}
    Marca: {item.marquinha.Nome}

    Cadastrado Por:
    Data: {DataProduto}");
            }
        }

        public void DeletarProduto()
        {
            Console.WriteLine($"Qual o codigo do produto que deseja excluir?: ");
            int excluirProduto = int.Parse(Console.ReadLine());
            Produto ProdutoExcluido = listaDeProdutos.Find(z => z.Codigo == excluirProduto);
            int index = listaDeProdutos.IndexOf(ProdutoExcluido);
            listaDeProdutos.RemoveAt(index);
            Console.WriteLine($"Produto Excluído!");
        }

    }
}