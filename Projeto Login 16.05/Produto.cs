namespace Projeto_Login_16._05
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastroProduto { get; private set; } = DateTime.Now;
        public Usuario CadastradoPor { get; private set; }

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
        public string CadastrarProduto()
        {
            Console.WriteLine($"Qual o código do produto?: ");
            int CodigoProduto = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o nome do produto?: ");
            string NomeProduto = Console.ReadLine();
            Console.WriteLine($"Qual o valor do produto?: ");
            float PrecoProduto = float.Parse(Console.ReadLine());
            DataCadastroProduto = DateTime.Now;

            listaDeProdutos.Add(new Produto(CodigoProduto, NomeProduto, PrecoProduto));

            return "Produto Cadastrado com sucesso!";
        }


        public void ListarProduto()
        {
            foreach (var item in listaDeMarcas)
            {
                Console.WriteLine(@$"
    Código: {item.Codigo} 
    Nome: {item.Nome} 
    Data: {DataMarca}");
            }
        }

        public void DeletarProduto()
        {
            Console.WriteLine($"asd");

        }

    }
}