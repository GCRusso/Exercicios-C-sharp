using Exercicio_25._05_MVC_LISTA.Model;

namespace Exercicio_25._05_MVC_LISTA.View
{
    public class EventosView
    {
        public void Listar(List<Evento> eventos)
        {
            Console.Clear();
            foreach (var item in eventos)
            {
                Console.WriteLine(@$"
                Nome: {item.Nome}
                Descrição: {item.Descricao}
                Data: {item.Data}
                ");
            }
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();
            Console.WriteLine($"Dados Do Evento");
            Console.WriteLine($"");
            Console.WriteLine($"Nome do Evento: ");
            novoEvento.Nome = Console.ReadLine();
            Console.WriteLine($"Descrição: ");
            novoEvento.Descricao = Console.ReadLine();
            Console.WriteLine($"Data: ");
            novoEvento.Data = Console.ReadLine();
            
            return novoEvento;
        }
    }
}