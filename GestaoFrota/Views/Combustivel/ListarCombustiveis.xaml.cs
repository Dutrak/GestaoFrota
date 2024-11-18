using GestaoFrota.Repositorios;

namespace GestaoFrota.Views.Combustivel;

public partial class ListarCombustiveis : ContentPage
{
    private CombustivelRepositorio cr;
    
    public ListarCombustiveis()
    {
        InitializeComponent();
        cr = new CombustivelRepositorio();
    }

    private void TasksList_OnItemTapped(object? sender, ItemTappedEventArgs e)
    {
        if (sender is ListView listView && listView.SelectedItem is Modelos.Combustivel combustivel)
        {
            string tipo = combustivel.Tipo;
            Navigation.PushAsync(new EditarDeletarCombustivel(tipo));
        }
    }
}