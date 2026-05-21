using MauiAppHotel.Models;
using Microsoft.Extensions.DependencyInjection;


namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suite Presidencial",
                ValorAdulto = 110.00,
                ValorCrianca = 55.00
            },
            new Quarto()
            {
                Descricao = "Suite Elegante",
                ValorAdulto = 80.00,
                ValorCrianca = 40.00
            },
            new Quarto()
            {
                Descricao = "Suite Essencial",
                ValorAdulto = 50,
                ValorCrianca = 25
            },
            new Quarto()
            {
                Descricao = "Suite Básica",
                ValorAdulto = 25,
                ValorCrianca = 12.5
            }
        };
        public App()
        {
            InitializeComponent();
        }


        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(
                new NavigationPage(
                    new Views.TelaInicial()
                ))
            {
                Width = 400,
                Height = 600
            };
        }
    }
}