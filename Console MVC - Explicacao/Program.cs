using Console_MVC.Controller;
using Console_MVC.Model;

Produto p = new Produto();
//instancia um objeto do controlador e chama o metodo para view
ProdutoController controller = new ProdutoController();
controller.ListarProdutos();
