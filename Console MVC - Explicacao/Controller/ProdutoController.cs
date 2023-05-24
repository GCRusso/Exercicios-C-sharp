using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        //instancias objeto Produto e ProdutoView, todas as classes que será utilizada tem que instanciar o objeto
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            // como é uma lista tem que instanciar como uma lista, chamado pela MODEL
            List<Produto> produtos = produto.Ler();

            //chamada do método de exibição(VIEW) recebendo como argumento a lista
            produtoView.Listar(produtos);

        }

    }
}