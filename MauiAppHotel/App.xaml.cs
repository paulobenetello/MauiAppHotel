using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }


        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(
                new NavigationPage(
                    new Views.ContratacaoHospedagem()
                ))
            {
                Width = 400,
                Height = 600
            };
        }
    }
}