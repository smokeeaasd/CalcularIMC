using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcularIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void calcular_Clicked(object sender, EventArgs e)
        {
            float peso = float.Parse(Peso.Text);
            float altura = float.Parse(Altura.Text);

            Double imc = Math.Round(peso / (altura * altura), 2);

            String classeIMC = "";
            if (imc < 18.5)
            {
                classeIMC = "Abaixo do Peso";
            }
            else if (imc > 18.5 && imc < 24.9)
            {
                classeIMC = "Peso Normal";
            }
            else if (imc > 25 && imc < 29.9)
            {
                classeIMC = "Sobrepeso";
            }
            else if (imc > 30 && imc < 34.9)
            {
                classeIMC = "Obesidade Grau I";
            }
            else if (imc > 35 && imc < 39.9)
            {
                classeIMC = "Obesidade Grau II";
            }
            else if (imc > 40)
            {
                classeIMC = "Obesidade Mórbida";
            }

            DisplayAlert($"Seu imc é de: {imc}.", $"{classeIMC}", "OK");

            Peso.Text = "";
            Altura.Text = "";
        }
    }
}
