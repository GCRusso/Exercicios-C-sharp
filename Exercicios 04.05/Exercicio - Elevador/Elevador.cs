namespace Exercicio___Elevador
{
    public class Elevador
    {
        public int pessoas { get; private set; } = 0;
        public int capacidadeMax { get; private set; } = 6;
        public int andares { get; private set; } = 0;
        public string Inicializa()
        {
            return @"
          Elevador Social

Capacidade do elevador: MAX. 6 Pessoas 
        
Temos 5 andares disponiveis no nosso predio";
        }
        public void Entrar()
        {
    
                if (pessoas < 6)
                {
                    pessoas++;
                    Console.WriteLine($"Entrou 1 pessoa.");
                }
                else
                {
                    Console.WriteLine($"Elevador lotado!");
                }
            
        }
        public void Sair()
        {

            if (pessoas > 0)
            {
                pessoas--;
                Console.WriteLine($"Saiu 1 pessoa");
            }

            else
            {
                Console.WriteLine($"Nao ha pessoas para sair");
            }
        }

        public void Subir()
        {

            if (andares < 5)
            {
                andares++;
                Console.WriteLine($"{andares}º Andar");
            }
            else
            {
                Console.WriteLine($"Voce ja esta no ultimo andar");
            }
        }
        public void Descer()
        {
            if (andares > 0)
            {
                andares--;
                Console.WriteLine($"{andares}º Andar");
            }
            else
            {
                Console.WriteLine($"Voce esta no Terreo");
            }

        }



    }
}