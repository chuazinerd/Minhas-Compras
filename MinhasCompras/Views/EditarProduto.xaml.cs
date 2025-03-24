using MinhasCompras.Models;

namespace MinhasCompras.Views;

public partial class EditarProduto : ContentPage
{
	public EditarProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto produto_anexado = BindingContext as Produto;
            // Cria um novo produto com as informações preenchidas
            Produto p = new Produto
            {
                Id = produto_anexado.Id,
                Descricao = txt_descricao.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_preco.Text),
            };

            // Tenta salvar o produto no banco
            await App.Db.Update(p);
            // Exibe mensagem de sucesso
            await DisplayAlert("Sucesso", "Registro Atualizado", "Ok");
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            // Exibe erro caso algo dê errado
            await DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}