namespace Exercicio___Jogador
{
    public class JogadorAtaque : Jogador
    {


        public void AposentadoriaAtaque()
        {
            int idade = DateTime.Now.Year - AnoNascimento;
            idade--;
            int aposentadoria = 35 - idade;
            Console.WriteLine($"Tempo para aposentadoria do {Nome}: {aposentadoria} anos. ");
        }
    }
}