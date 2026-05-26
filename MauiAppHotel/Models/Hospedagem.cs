namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public double QtdAdultos { get; set; }
        public double QtdCriancas { get; set; }
        public DateTime DataCheckin {  get; set; }
        public DateTime DataCheckout { get; set; }
        public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckin).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_adultos = QtdAdultos * QuartoSelecionado.ValorAdulto;
                double valor_criancas = QtdCriancas * QuartoSelecionado.ValorCrianca;

                double total = (valor_adultos + valor_criancas) * Estadia;
                return total;
            }
        }
    }
}
