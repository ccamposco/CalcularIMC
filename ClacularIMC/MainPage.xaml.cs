using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClacularIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var altura = double.Parse(Altura.Text);
            var peso = double.Parse(Peso.Text);

            var imc = peso / (altura * altura);
            Imc.Text = imc.ToString();
            string resultado;
            if (imc < 18.5)
            {
                resultado = "Tu peso es bajo";
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                resultado = "Tu peso es normal";
            }
            else if (imc > 25.1 && imc <= 29.9)
            {
                resultado = "Tienes sobrepeso";
            }
            else resultado = "Tienes obecidad, cuídate";

            DisplayAlert("Resultado", resultado, "OK");
        }

    }
}
