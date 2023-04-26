namespace Exercicio_25._04___celular
{
    public class Celular
    {
        bool ligar;
        string ligado = "";
        //Cadastro do celular
        public void CadastroCelular()
        {
            Console.WriteLine($"***** Bem vindo ao CadastraPhone *****");
            Console.WriteLine($"");
            Console.WriteLine($"Qual o modelo do celular?: ");
            string modelo = Console.ReadLine();
            Console.WriteLine($"Qual a cor do celular?: ");
            string cor = Console.ReadLine();
            Console.WriteLine(@$"Qual o tamanho do celular?: ");
            string tamanho = Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"Celular Cadastrado com sucesso!!!");

        }

        //Menu o que deseja fazer


        public void LigarCelular()
        {
            do
            {

                Console.WriteLine($"Seu celular esta ligado? S/N: ");
                ligado = Console.ReadLine().ToLower();

                if (ligado == "s")
                {
                    ligar = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ligue o seu celular!! ");
                    Console.ResetColor();

                }
            } while (ligado != "s");


        }
        public void FazerLigacao()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Chamando...");
        Console.ResetColor();
        
    }
    public void EnviarMensagem()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Escreva sua mensagem: ");
        Console.ResetColor();
        string msg = Console.ReadLine();
        Console.WriteLine($"");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Mensagem enviada!");
        Console.ResetColor();
    
    }

    }
}