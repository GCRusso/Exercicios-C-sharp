using Exercicio_25._05_MVC_LISTA.Model;
using Exercicio_25._05_MVC_LISTA.View;

namespace Exercicio_25._05_MVC_LISTA.Controller
{
    public class EventoController
    {
        Evento evento = new Evento();
        EventosView eventoView = new EventosView();

        public void ListarEventos()
        {
            List<Evento> eventos = evento.Ler();
            eventoView.Listar(eventos);
        }

        public void CadastrarEvento()
        {
            Evento novoEvento = eventoView.Cadastrar();

            evento.Inserir(novoEvento);
        }
    }
}