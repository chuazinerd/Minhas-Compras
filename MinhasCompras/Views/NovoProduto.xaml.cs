// Importa o modelo de Produto
using MinhasCompras.Models;

namespace MinhasCompras.Views
{
    // Classe para a pagina de adicionar um novo produto
    public partial class NovoProduto : ContentPage
    {
        // Construtor da p�gina
        public NovoProduto()
        {
            InitializeComponent(); // Inicializa os componentes da tela
        }

        // M�todo chamado quando o bot�o � clicado
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Cria um novo produto com as informa��es preenchidas
                Produto p = new Produto
                {
                    Descricao = txt_descricao.Text,
                    Quantidade = Convert.ToDouble(txt_quantidade.Text),
                    Preco = Convert.ToDouble(txt_preco.Text),
                };

                // Tenta salvar o produto no banco
                await App.Db.Insert(p);
                // Exibe mensagem de sucesso
                await DisplayAlert("Sucesso", "Registro inserido", "Ok");
            }
            catch (Exception ex)
            {
                // Exibe erro caso algo d� errado
                await DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }
}