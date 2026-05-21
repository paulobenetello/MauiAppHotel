namespace MauiAppHotel.Views;

public partial class TelaInicial : ContentPage
{
	public TelaInicial()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new ContratacaoHospedagem());
		}
		catch (Exception ex) {
			DisplayAlert("OPS", ex.Message, "OK");
		}
    }
}