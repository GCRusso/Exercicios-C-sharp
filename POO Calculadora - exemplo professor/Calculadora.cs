namespace POO_Calculadora___exemplo_professor
{
    public class Calculadora
    {
        // propriedades
        public float n1;
        public float n2;

        
        // métodos
        public float Somar()
        {
//this = para chamar propriedades e metodos dentro da propria classe
            return  this.n1 + this.n2;
        }
        public float Subtrair()
        {
            return  this.n1 - this.n2;
        }
        public float Multiplicar()
        {
            return  this.n1 * this.n2;
        }
        public float Dividir()
        {
            return  this.n1 / this.n2;
        }
    }
}