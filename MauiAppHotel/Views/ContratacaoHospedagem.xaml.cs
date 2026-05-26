using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
    public ContratacaoHospedagem()
	{
		InitializeComponent();
        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        DateTime dataCheckin = Convert.ToDateTime(dtpck_checkin.Date);
        dtpck_checkout.MinimumDate = dataCheckin.AddDays(1);
        dtpck_checkout.MaximumDate = dataCheckin.AddMonths(6);
    }
	private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
            Hospedagem h = new Hospedagem
            {
                QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                QtdAdultos = Convert.ToInt32(stp_adultos.Value),
                QtdCriancas = Convert.ToInt32(stp_criancas.Value),
                DataCheckin =  (DateTime)dtpck_checkin.Date,
                DataCheckout = (DateTime)dtpck_checkout.Date
            };

			await Navigation.PushAsync(new HospedagemContratada(){
                BindingContext = h
            });
		}
		catch (Exception ex) { 
			await DisplayAlert("OPS", ex.Message, "OK");
		}
    }

    private async void Button_Clicked2(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new SobreNos());
        }
        catch (Exception ex)
        {
            await DisplayAlert("OPS", ex.Message, "OK");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = (DateTime)elemento.Date;
        
        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}