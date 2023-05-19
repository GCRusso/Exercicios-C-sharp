namespace Projeto_Login_16._05
{
    public class Marca
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataMarca { get; private set; } = DateTime.Now;

        public static List<Marca> listaDeMarcas = new List<Marca>();
        public Marca()
        {

        }
        public Marca(int _codigo, string _nome, DateTime _datamarca)
        {
            Codigo = _codigo;
            Nome = _nome;
            DataMarca = _datamarca;
        }

        public Marca CadastrarMarca()
        {
            Marca marca = new Marca();
            Console.WriteLine($"Qual o código da marca?: ");
            int codigoMarca = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o nome da marca?: ");
            string nomeMarca = Console.ReadLine();
            marca.Nome = nomeMarca;
            marca.Codigo = codigoMarca;
            marca.DataMarca = DateTime.Now;


            listaDeMarcas.Add(marca);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@$"
            Marca Cadastrada com sucesso

            Código: {marca.Codigo} 
            Nome: {marca.Nome} 
            Data: {marca.DataMarca}
            
            --------------------------------------------------------
            ");
            Console.ResetColor();
            return marca;

        }

        public void ListarMarca()
        {
            foreach (var item in listaDeMarcas)
            {
                Console.WriteLine(@$"
    Código: {item.Codigo} 
    Nome: {item.Nome}
    Data: {DataMarca}");
            }
        }

        public void DeletarMarca()
        {
            Console.WriteLine($"Qual o codigo da marca que deseja excluir?: ");
            int excluirMarca = int.Parse(Console.ReadLine());
            Marca MarcaExcluida = listaDeMarcas.Find(z => z.Codigo == excluirMarca);
            int index = listaDeMarcas.IndexOf(MarcaExcluida);
            listaDeMarcas.RemoveAt(index);
            Console.WriteLine($"Marca Deletada!");

        }
    }
}