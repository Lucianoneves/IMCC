using System.Globalization;

namespace CalcularIMCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularIMC_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text, CultureInfo.InvariantCulture);
            double altura = Convert.ToDouble(txtAltura.Text, CultureInfo.InvariantCulture);

            double imc = peso / (altura * altura);

            lbIMC.Text = imc.ToString("F2");
            lbIMC.Visible = true;

            string Classificacao = string.Empty;

            if (imc < 16.9)
                Classificacao = "Muito abaixo do peso";
            else if (imc >= 17 && imc <= 18.4)
                Classificacao = "Abaixo do peso";
            else if (imc >= 18.5 && imc <= 24.9)
                Classificacao = "Peso Normal";
            else if (imc >= 25 && imc <= 29.9)
                Classificacao = " Acima do Peso";
            else if (imc >= 30 && imc <= 34.9)
                Classificacao = " Obesidade grau 1";
            else if (imc >= 35 && imc <= 40)
                Classificacao = " Obesidade grau 2";
            else if (imc > 40)
                Classificacao = " Obesidade grau 3";

            lbClassificacao.Text = Classificacao;
            lbClassificacao.Visible = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtPeso.Text = string.Empty;
            txtAltura.Text = string.Empty;

            lbIMC.Visible = false;
            lbClassificacao.Visible = false;

        }
    }
}
