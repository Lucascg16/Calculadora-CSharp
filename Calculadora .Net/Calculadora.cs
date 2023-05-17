using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora.Net
{
    public partial class Calculadora : Form
    {
        double Num1 = 0, Num2 = 0, resultado = 0;//Os dois valores que a calculadora precisa pra fazer o calculo.
        string OperacaoStatus = "", OperacaoControle = "";//OpStatus - indica a calculadora qual conta ela deve fazer. || OpControle - indica a calculadora se a porcentagem e somando ou subtraindo.
        bool ControleContinuidade = true;//Indica se a conta vai continuar ou se ela vai resetar e comecar um novo ciclo, setado como false nao existe continuidade.
        public Calculadora()
        {
            InitializeComponent();
            VisorAux.Text = string.Empty;
        }

        private void Button_Zero_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                Visor.Text = "";
                VisorAux.Text = "";
                ControleContinuidade = true;
            }
            Visor.Text += "0";

        }

        private void Button_Um_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                Visor.Text = "";
                VisorAux.Text = "";
                ControleContinuidade = true;
            }

            Visor.Text += "1";            
        }

        private void Button_Dois_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                Visor.Text = "";
                VisorAux.Text = "";
                ControleContinuidade = true;
            }

            Visor.Text += "2";
        }

        private void Button_Tres_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                Visor.Text = "";
                VisorAux.Text = "";
                ControleContinuidade = true;
            }

            Visor.Text += "3";
        }

        private void Button_Quatro_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                Visor.Text = "";
                VisorAux.Text = "";
                ControleContinuidade = true;
            }

            Visor.Text += "4";
        }

        private void Button_Cinco_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                Visor.Text = "";
                VisorAux.Text = "";
                ControleContinuidade = true;
            }

            Visor.Text += "5";
        }

        private void Button_Seis_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                Visor.Text = "";
                VisorAux.Text = "";
                ControleContinuidade = true;
            }

            Visor.Text += "6";
        }

        private void Button_Sete_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                Visor.Text = "";
                VisorAux.Text = "";
                ControleContinuidade = true;
            }

            Visor.Text += "7";
        }

        private void Button_Oito_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                Visor.Text = "";
                VisorAux.Text = "";
                ControleContinuidade = true;
            }

            Visor.Text += "8";
        }

        private void Button_Nove_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                Num1 = 0;
                Num2 = 0;
                Visor.Text = "";
                VisorAux.Text = "";
                ControleContinuidade = true;
            }

            Visor.Text += "9";         
        }

        private void Button_Ponto_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
                Visor.Text = "0.";
            else
                Visor.Text += ".";
        }

        private void Button_Inverter_Click(object sender, EventArgs e)
        {
            Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
            Num1 *= -1;
            Visor.Text = Convert.ToString(Num1);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Visor.Text = "";
            VisorAux.Text = "";
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
                    {
                        if (ControleContinuidade == true)
                        {
                            Num2 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                            VisorAux.Text += $"{Convert.ToString(Num2)} =";
                            resultado = Calculos.Soma(Num1, Num2);
                        }
                        else
                        {
                            resultado += Num2;
                            VisorAux.Text = $"{Convert.ToString(resultado - Num2)} + {Convert.ToString(Num2)} =";
                        }
                    }                   

                    Visor.Text = Convert.ToString(resultado);
                    ControleContinuidade = false;
                    break;

                case "Subtracao":
                    if (Visor.Text != "")
                    {
                        if (ControleContinuidade == true)
                        {
                            Num2 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                            VisorAux.Text += $"{Convert.ToString(Num2)} =";
                            resultado = Calculos.Subtracao(Num1, Num2);
                        }
                        else
                        {
                            resultado -= Num2;
                            VisorAux.Text = $"{Convert.ToString(resultado + Num2)} - {Convert.ToString(Num2)} =";
                        }
                    }                   

                    Visor.Text = Convert.ToString(resultado);
                    ControleContinuidade = false;
                    break;

                case "Multiplicacao":
                    if (Visor.Text != "")
                    {
                        if (ControleContinuidade == true)
                        {
                            Num2 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                            VisorAux.Text += $"{Convert.ToString(Num2)} =";
                            resultado = Calculos.Multiplicacao(Num1, Num2);
                        }
                        else
                        {
                            resultado *= Num2;
                            VisorAux.Text = $"{Convert.ToString(resultado / Num2)} x {Convert.ToString(Num2)} =";
                        }
                    }

                    Visor.Text = Convert.ToString(resultado);
                    ControleContinuidade = false;
                    break;

                case "Divisao":
                    if (Visor.Text != "")
                    {
                        if (ControleContinuidade == true)
                        {
                            Num2 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                            VisorAux.Text += $"{Convert.ToString(Num2)} =";
                            resultado = Calculos.Divisao(Num1, Num2);
                        }
                        else
                        {
                            resultado /= Num2;
                            VisorAux.Text = $"{Convert.ToString(resultado * Num2)} ÷ {Convert.ToString(Num2)} =";
                        }
                    }

                    Visor.Text = Convert.ToString(resultado);
                    ControleContinuidade = false;
                    break;

                case "Porcento":
                    double porcento = Calculos.Porcentagem(Num1, Num2);

                    if (OperacaoControle == "+")
                    {
                        resultado = Num1 + porcento;
                        Visor.Text = Convert.ToString(resultado);
                        VisorAux.Text += $"{Convert.ToString(porcento)} =";
                    }
                    else if (OperacaoControle == "-")
                    {
                        resultado = Num1 - porcento;
                        Visor.Text = Convert.ToString(resultado);
                        VisorAux.Text += $"{Convert.ToString(porcento)} =";
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
            {
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                VisorAux.Text = $"{Convert.ToString(Num1)} + ";
            }
                
            OperacaoStatus = "Soma";
            Visor.Text = "";
            OperacaoControle = "+";
            ControleContinuidade = true;
        }

        private void Button_Subtracao_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
            {
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                VisorAux.Text = $"{Convert.ToString(Num1)} - ";
            }               

            OperacaoStatus = "Subtracao";
            Visor.Text = "";
            OperacaoControle = "-";
            ControleContinuidade = true;
        }

        private void Button_Multiplicacao_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
            {
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                VisorAux.Text = $"{Convert.ToString(Num1)} X ";
            }               

            OperacaoStatus = "Multiplicacao";
            Visor.Text = "";
            ControleContinuidade = true;
        }

        private void Button_Divisao_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
            {
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                VisorAux.Text = $"{Convert.ToString(Num1)} ÷ ";
            }               

            OperacaoStatus = "Divisao";
            Visor.Text = "";
            ControleContinuidade = true;
        }

        private void Button_Elevado_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
            {
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                VisorAux.Text = $"sqrt({Convert.ToString(Num1)})";
            }               

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
            {
                Num1 = double.Parse(Visor.Text, CultureInfo.InvariantCulture);
                VisorAux.Text = $"√({Convert.ToString(Num1)})";
            }

            OperacaoStatus = "Raiz";
            ControleContinuidade = true;
            Button_Resultado_Click_1(null, null);
        }

    }
}
