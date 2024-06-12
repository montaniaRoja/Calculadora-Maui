namespace Calculadora.Views
{
    public partial class Pantalla1 : ContentPage
    {
        public Pantalla1()
        {
            InitializeComponent();
        }

        private void OnSumaClicked(object sender, EventArgs e)
        {
            try
            {
                String operacion = "sumar";
                float num1 = float.Parse(numero1.Text);
                float num2 = float.Parse(numero2.Text);
                calcular(operacion, num1, num2);
            }
            catch (FormatException)
            {
                resultadoError.Text = "Error: Introduce números válidos";
            }
            catch (Exception ex)
            {
                resultadoError.Text = $"Error: {ex.Message}";
            }
        }

        private void OnRestaClicked(object sender, EventArgs e)
        {
            try
            {
                String operacion = "restar";
                float num1 = float.Parse(numero1.Text);
                float num2 = float.Parse(numero2.Text);
                calcular(operacion, num1, num2);
            }
            catch (FormatException)
            {
                resultadoError.Text = "Error: Introduce números válidos";
            }
            catch (Exception ex)
            {
                resultadoError.Text = $"Error: {ex.Message}";
            }
        }

        private void OnMultClicked(object sender, EventArgs e)
        {
            try
            {
                String operacion = "multiplicar";
                float num1 = float.Parse(numero1.Text);
                float num2 = float.Parse(numero2.Text);
                calcular(operacion, num1, num2);
            }
            catch (FormatException)
            {
                resultadoError.Text = "Error: Introduce números válidos";
            }
            catch (Exception ex)
            {
                resultadoError.Text = $"Error: {ex.Message}";
            }
        }

        private void OnDivClicked(object sender, EventArgs e)
        {
            try
            {
                String operacion = "dividir";
                float num1 = float.Parse(numero1.Text);
                float num2 = float.Parse(numero2.Text);
                if (num2 != 0)
                {
                    calcular(operacion, num1, num2);
                }
                else
                {
                    resultadoError.Text = "Error: División por cero";
                }
            }
            catch (FormatException)
            {
                resultadoError.Text = "Error: Introduce números válidos";
            }
            catch (Exception ex)
            {
                resultadoError.Text = $"Error: {ex.Message}";
            }
        }

        private async void calcular(String operacion, float num1, float num2)
        {
            float result = 0;

            switch (operacion)
            {
                case "sumar":
                    result = num1 + num2;
                    break;
                case "restar":
                    result = num1 - num2;
                    break;
                case "multiplicar":
                    result = num1 * num2;
                    break;
                case "dividir":
                    result = num1 / num2;
                    break;
                default:
                    break;
            }

            numero1.Text = "";
            numero2.Text = "";
            resultadoError.Text = "";
            string resultado = result.ToString();
            await Navigation.PushAsync(new PantallaResultado(resultado));
        }
    }
}
