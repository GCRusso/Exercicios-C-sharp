namespace Exercicio_24._04
{
    public class Alunos
    {
        float media = 0f;
        float valorMensalidade = 0f;
        bool bolsaTrue;

        //Planilha de Cadastro do aluno 
        public void Cadastro()
        {
            Console.WriteLine(@$"*** SENAI CURSOS ***");
            Console.WriteLine();
            Console.WriteLine($"Digite somente os dados do aluno");
            Console.WriteLine();

            Console.WriteLine($"Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o curso?: ");
            string curso = Console.ReadLine();
            Console.WriteLine($"RG: ");
            string rg = Console.ReadLine();
            do
            {
                Console.WriteLine($"Qual a media final? entre 0 e 10: ");
                media = int.Parse(Console.ReadLine());

            } while (media > 10);
            Console.WriteLine($"Qual o valor da mensalidade?: ");
            valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Este aluno é um bolsista? S/N");
            string bolsa = Console.ReadLine().ToLower();

            if (bolsa == "s")
            {
                bolsaTrue = true;
                if (media >= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O aluno {nome} ganhou um desconto de 50% da sua mensalidade!");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Valor com desconto: R${valorMensalidade = valorMensalidade / 100 * 50}");
                    Console.ResetColor();
                }
                if (media == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O aluno {nome} ganhou um desconto de 30% da sua mensalidade!");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Valor com desconto: R${valorMensalidade = valorMensalidade - valorMensalidade / 100 * 30}");
                    Console.ResetColor();
                }
                if (media <= 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"o {nome} não tem direito ao desconto, nota media abaixo de 7.");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Valor: R${valorMensalidade}");
                    Console.ResetColor();
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Este aluno não é um bolsista, sem desconto na mensalidade!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Valor mensalidade: R${valorMensalidade}");
                Console.ResetColor();
            }
        }

        public float VerMediaFinal()
        {
            return this.media;
        }
        public float VerMensalidade()
        {
            return this.valorMensalidade;
        }
    }
}