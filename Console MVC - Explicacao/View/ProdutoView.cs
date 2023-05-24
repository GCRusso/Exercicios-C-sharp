using Console_MVC.Model;
namespace Console_MVC.View
{
    public class ProdutoView
    {
        //Método para exibir os dados da lista de produtos
        public void Listar(List<Produto> produtos)
        {
            Console.Clear();
            //foreach utilizado para ler a lista passada como parâmetro de método
            foreach (var item in produtos)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo} ");
                Console.WriteLine($"Nome: {item.Nome} ");
                Console.WriteLine($"Preco: {item.Preco:C} ");

            }
        }
    }
}