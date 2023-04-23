using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora.Net
{
    public partial class Calculadora : Form
    {
        double Num1 = 0, Num2 = 0;
        string OperacaoStatus = "", OperacaoControle = "";
        bool ControleContinuidade = true;
        public Calculadora()
        {
            InitializeComponent();

        }

        private void Button_Zero_Click(object sender, EventArgs e)
        {
            Visor.Text += "0";
            VisorAux.Text = "";

            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                ControleContinuidade = true;
            }
        }

        private void Button_Um_Click(object sender, EventArgs e)
        {
            Visor.Text += "1";
            VisorAux.Text = "";

            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                ControleContinuidade = true;
            }
        }

        private void Button_Dois_Click(object sender, EventArgs e)
        {
            Visor.Text += "2";
            VisorAux.Text = "";

            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                ControleContinuidade = true;
            }
        }

        private void Button_Tres_Click(object sender, EventArgs e)
        {
            Visor.Text += "3";
            VisorAux.Text = "";

            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                ControleContinuidade = true;
            }
        }

        private void Button_Quatro_Click(object sender, EventArgs e)
        {
            Visor.Text += "4";
            VisorAux.Text = "";

            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                ControleContinuidade = true;
            }
        }

        private void Button_Cinco_Click(object sender, EventArgs e)
        {
            Visor.Text += "5";
            VisorAux.Text = "";

            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                ControleContinuidade = true;
            }
        }

        private void Button_Seis_Click(object sender, EventArgs e)
        {
            Visor.Text += "6";
            VisorAux.Text = "";

            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                ControleContinuidade = true;
            }
        }

        private void Button_Sete_Click(object sender, EventArgs e)
        {
            Visor.Text += "7";
            VisorAux.Text = "";

            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                ControleContinuidade = true;
            }
        }

        private void Button_Oito_Click(object sender, EventArgs e)
        {
            Visor.Text += "8";
            VisorAux.Text = "";

            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                ControleContinuidade = true;
            }
        }

        private void Button_Nove_Click(object sender, EventArgs e)
        {
            Visor.Text += "9";
            VisorAux.Text = "";

            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                ControleContinuidade = true;
            }
        }

        private void Button_Ponto_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
                Visor.Text = "0.";
            else
                Visor.Text += ".";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Visor.Text = "";
            Num1 = 0;
            Num2 = 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Visor.Text = string.Empty;
        }

        private void Button_Resultado_Click_1(object sender, EventArgs e)
        {
            switch (OperacaoStatus)
            {
                case "Soma":
                    if (Visor.Text != "")
                        Num2 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                    Visor.Text = Convert.ToString(Calculos.Soma(Num1, Num2));
                    ControleContinuidade = false;
                    break;
                case "Subtracao":
                    if (Visor.Text != "")
                        Num2 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                    Visor.Text = Convert.ToString(Calculos.Subtracao(Num1, Num2));
                    ControleContinuidade = false;
                    break;
                case "Multiplicacao":
                    if (Visor.Text != "")
                        Num2 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                    Visor.Text = Convert.ToString(Calculos.Multiplicacao(Num1, Num2));
                    ControleContinuidade = false;
                    break;
                case "Divisao":
                    if (Visor.Text != "")
                        Num2 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                    Visor.Text = Convert.ToString(Calculos.Divisao(Num1, Num2));
                    ControleContinuidade = false;
                    break;
                case "Porcento":
                    double Resultado;
                    var porcento = Calculos.Porcentagem(Num2);

                    if (OperacaoControle == "+")
                    {
                        Resultado = Num1 / porcento;
                        Visor.Text = Convert.ToString(Num1 + Resultado);
                    }else if (OperacaoControle == "-")
                    {
                        Resultado = Num1 * porcento;
                        Visor.Text = Convert.ToString(Num1 - Resultado);
                    }
                    ControleContinuidade = false;
                    break;
                case "Elevado":
                    Visor.Text = Convert.ToString(Calculos.Quadrado(Num1));
                    ControleContinuidade = false;
                    break;
                case "Raiz":
                    Visor.Text = Convert.ToString(Calculos.Raiz_Quadrada(Num1));
                    ControleContinuidade = false;
                    break;
            }
        }

        private void Button_Soma_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);

            OperacaoStatus = "Soma";
            Visor.Text = "";
            OperacaoControle = "+";
            ControleContinuidade = true;
        }

        private void Button_Subtracao_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);

            OperacaoStatus = "Subtracao";
            Visor.Text = "";
            OperacaoControle = "-";
            ControleContinuidade = true;
        }

        private void Button_Multiplicacao_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);

            OperacaoStatus = "Multiplicacao";
            Visor.Text = "";
            ControleContinuidade = true;
        }

        private void Button_Divisao_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);

            OperacaoStatus = "Divisao";
            Visor.Text = "";
            ControleContinuidade = true;
        }

        private void Button_Elevado_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);

            OperacaoStatus = "Elevado";
            ControleContinuidade = true;
            Button_Resultado_Click_1(null, null);
        }

        private void Button_Porcento_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
                Num2 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);

            OperacaoStatus = "Porcento";
            Visor.Text = "";
            ControleContinuidade = true;
        }

        private void Button_Raiz_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);

            OperacaoStatus = "Raiz";
            ControleContinuidade = true;
            Button_Resultado_Click_1(null, null);
        }
    }
}
