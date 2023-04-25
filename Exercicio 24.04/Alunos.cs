namespace Exercicio_24._04
{
    public class Alunos
    {
        float media = 0f;
        float valorMensalidade = 0f;
        public void Cadastro()
        {
            Console.WriteLine(@$"*** SENAI CURSOS ***");
            Console.WriteLine();
            Console.WriteLine($"Digite os dados somente do aluno");
            Console.WriteLine();

            Console.WriteLine($"Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o curso?: ");
            string curso = Console.ReadLine();
            Console.WriteLine($"RG: ");
            string rg = Console.ReadLine();
            Console.WriteLine($"Qual a media final?: ");
            media = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o valor da mensalidade?: ");
            valorMensalidade = float.Parse(Console.ReadLine());

            if (media >= 8)
            {
                Console.WriteLine($"Este aluno e um bolsista!");
                Console.WriteLine($"Ganhou um desconto de 50% da mensalidade ");
                Console.WriteLine($"o valor da mensalidade e de: {valorMensalidade} desconto aplicado: {valorMensalidade }");
                


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