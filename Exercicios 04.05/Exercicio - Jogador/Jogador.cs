namespace Exercicio___Jogador
{

    public abstract class Jogador
    {
        public string Nome;
        public int AnoNascimento;
        public string Nacionalidade;
        public float Altura;
        public float Peso;

        public void CadastroJogador()
        {
            Console.WriteLine($"Dados do Jogador");
            Console.WriteLine($"");
            Console.WriteLine($"Nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine($"Ano de nascimento (AAAA): ");
            AnoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nacionalidade: ");
            Nacionalidade = Console.ReadLine();
            Console.WriteLine($"Altura: ");
            Altura = float.Parse(Console.ReadLine());
            Console.WriteLine($"Peso: ");
            Peso = float.Parse(Console.ReadLine());
        }

    }
}
