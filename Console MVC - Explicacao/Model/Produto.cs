namespace Console_MVC.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        /*private reconhecida somente dentro desta classe e ela é uma constante significa que ela nao pode ser alterada em nenhum momento do codigo, tudo que esta dentro do CSV é uma string
        Caminho da pasta e do arquivo definido*/
        private const string PATH = "Database/Produto.csv";
        //Declarou a Database isoladamente
        private const string PATH_BASE = "Database";
        //Declarou os arquivos separadamente, pode ser qualquer tipo de arquivo
        private const string file1 = "xpto.txt";
        private const string file2 = "arquivo.docx";


        /*criando um construtor e identificar o que é pasta e o que é arquivo
        SPLIT = para utilizar o corte é com o caracter / corta somente STRING, cria uma cópia daquele texto e com os cortes é criado um Array 
        Exemplo: "Eduardo/Carlos/Produto.csv  ARRAY criado: Eduardo[0] Carlos[1] Produto.csv[2]"
        */
        public Produto()
        {
            /*foi criado uma nova string para guardar este novo valor do corte, sinalizei que o corte sera feito quando houver / e chamei o array de numero 0 que no caso é o Database*/
            string pasta = PATH.Split("/")[0]; //Database
            /*Directory é uma classe de pasta, se não existir a pasta, criar um diretorio pasta*/
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            /*Se não existir um arquivo então cria-se um arquivo*/
            if (!File.Exists(PATH))
            {
                File.Create(PATH);

            }
            //Se na pasta DATABASE não existir o file 1, então criase o file 1
            if (!File.Exists($"{PATH_BASE}/{file1}"))
            {
                File.Create($"{PATH_BASE}/{file1}");

            }
            //Se na pasta DATABASE não existir o file 2, então criase o file 2
            if (!File.Exists($"{PATH_BASE}/{file2}"))
            {
                File.Create($"{PATH_BASE}/{file2}");

            }

        }
        public List<Produto> Ler()
        {
            //Criar uma Lista
            List<Produto> produtos = new List<Produto>();

            //array de string que recebe cada linha do csv, aqui ele irá ler cada linha impressa no CSV
            string[] linhas = File.ReadAllLines(PATH);
            //para a leitura das linhas
            foreach (string item in linhas)
            {
                //antes do split
                //001;Coca;6,50

                //array que recebe os itens da linha separado por ";"
                string[] atributos = item.Split(";");

                //após o split
                //atributo [0] = "001"
                //atributo [1] = "Coca"
                //atributo [2] = "6,50"

                //instancia o de objeto produto
                Produto p = new Produto();

                //atribuir os dados dentro de um objeto
                p.Codigo = int.Parse(atributos[0]); //001
                p.Nome = atributos[1]; //Coca
                p.Preco = float.Parse(atributos[2]); //6,50

                //adiciona os objetos dentro da lista
                produtos.Add(p);
            }
            //retorna a lista de produtos
                return produtos;
        }
    }
}






