namespace Exercicio_25._05_MVC_LISTA.Model
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }

        private const string PATH = "Database";
        private const string PATHFILE = "Eventos.csv";


        //construtor para criação de arquivos database
        public Evento()
        {
           
            if (!Directory.Exists(PATH))
            {
                Directory.CreateDirectory(PATH);
            }

            if (!File.Exists($"{PATH}/{PATHFILE}"));
            {
                File.Create($"{PATH}/{PATHFILE}");
            }

        }

        public List<Evento> Ler()
        {
            //criando uma lista
            List<Evento> eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Evento e = new Evento();

                e.Nome = atributos[0];
                e.Descricao = atributos[1];
                e.Data = atributos[2];

                eventos.Add(e);
            }
            return eventos;
        }
        public string PrepararLinhasCSV(Evento e)
        {
            return $"{e.Nome};{e.Descricao};{e.Data}";
        }

        public void Inserir(Evento e)
        {
            string[] linhas ={PrepararLinhasCSV(e)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}