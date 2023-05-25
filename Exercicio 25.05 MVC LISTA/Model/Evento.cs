namespace Exercicio_25._05_MVC_LISTA.Model
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }

        private const string PATH = "Database/Eventos.csv";


        //construtor para criação de arquivos database
        public Evento()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }

        public List<Evento> Ler()
        {
            //criando uma lista
            List<Evento> Eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);


        }
    }
}