namespace Exercicio___Jogador
{
    public class JogadorDefesa : Jogador
    {
public void AposentadoriaZagueiro()
        {
            int idade = DateTime.Now.Year - AnoNascimento;
            idade--;
            int aposentadoria = 40 - idade;
            Console.WriteLine($"Tempo para aposentadoria do {Nome}: {aposentadoria} anos. ");
        }
    }
}