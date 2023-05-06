namespace Exercicio___Maquina_de_Cafe
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 500;

        public void FazerCafe()
        {
            if (acucarDisponivel > 0)
            {
                acucarDisponivel -= 10;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Seu cafézinho com 10 gramas de açucar esta sendo preparado!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não temos açucar suficente em nossa máquina Tabajaras Plus++ :(");
                Console.ResetColor();
                Console.WriteLine($"");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Esta sendo preparado um café sem açucar!");
                Console.ResetColor();
                Console.WriteLine($"Obrigado por utilizar nossa máquina Tabajaras Plus++");
                Console.ResetColor();
            }

        }
        public void FazerCafe(int acucar)
        {
            if (acucarDisponivel >= acucar)
            {
                acucarDisponivel -= acucar;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Seu cafézinho está sendo preparado com {acucar} gramas de açucar.");
                Console.WriteLine($"");
                Console.WriteLine($"Obrigado por utilizar nossa máquina Tabajaras Plus++");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não temos açucar suficente em nossa máquina Tabajaras Plus++ :(");
                Console.ResetColor();
                Console.WriteLine($"");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Esta sendo preparado um café sem açucar!");
                Console.ResetColor();
            }

        }
    }
}