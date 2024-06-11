namespace Calculadora.Views
{
    public partial class PantallaResultado : ContentPage
    {
        public PantallaResultado(string resultado)
        {
            InitializeComponent();
            ResultadoLabel.Text = resultado;
        }
    }
}
