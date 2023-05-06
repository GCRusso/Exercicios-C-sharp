namespace Exercicio___Jogador
{
    public class JogadorMeioCampo : Jogador
    {
        public void AposentadoriaMeioCampo()
        {
            int idade = DateTime.Now.Year - AnoNascimento;
            idade--;
            int aposentadoria = 38 - idade;
            Console.WriteLine($"Tempo para aposentadoria do {Nome}: {aposentadoria} anos. ");
        }
    }
}