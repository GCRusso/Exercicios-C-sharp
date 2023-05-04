namespace POO_Calculadora
{
    public class Calculadora
    {
        public void Soma()
        {
            Console.WriteLine($"*****Calculadora de SOMA*****");

            Console.WriteLine($"Informe o primeiro numero: ");
            float primeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o segundo numero: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} e de : {primeiroNumero + segundoNumero}");
        }
        public void Subtracao()
        {
            Console.WriteLine($"*****Calculadora de SUBTRACAO*****");

            Console.WriteLine($"Informe o primeiro numero: ");
            float primeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o segundo numero: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine($"A subtracao de {primeiroNumero} - {segundoNumero} e de : {primeiroNumero - segundoNumero}");
        }
        public void Multiplicacao()
        {
            Console.WriteLine($"*****Calculadora de MULTIPLICACAO*****");

            Console.WriteLine($"Informe o primeiro numero: ");
            float primeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o segundo numero: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine($"A multiplicacao de {primeiroNumero} X {segundoNumero} e de : {primeiroNumero * segundoNumero}");
        }
        public void Divisao()
        {
            Console.WriteLine($"*****Calculadora de DIVISAO*****");

            Console.WriteLine($"Informe o primeiro numero: ");
            float primeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o segundo numero: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            if(primeiroNumero == 0 || segundoNumero == 0)
            {
                Console.WriteLine($"Favor digitar um valor diferente de 0");
                
            }

            Console.WriteLine($"A divisao de {primeiroNumero} / {segundoNumero} e de : {primeiroNumero / segundoNumero}");
        }
    }
}
