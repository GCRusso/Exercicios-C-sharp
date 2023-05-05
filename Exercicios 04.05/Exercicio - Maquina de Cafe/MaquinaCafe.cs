namespace Exercicio___Maquina_de_Cafe
{
    public class MaquinaCafe
    {
        int acucarDisponivel = 500;

        public void FazerCafe(){
            if (acucarDisponivel > 0)
            {
                Console.WriteLine($"Seu cafe esta sendo preparado");
                
            }
            else
            {
                Console.WriteLine($"Nao ha açucar suficiente, preparando um cafe sem açucar.");
                
            }
                
        }
            public void FazerCafe(int acucar){
            acucarDisponivel;

            }
    }
}