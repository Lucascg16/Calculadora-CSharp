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

        private void Button_Number_Click(object sender, EventArgs e)
        {
            if (ControleContinuidade == false)
            {
                CalculadoraClear();
                ControleContinuidade = true;
            }
            Visor.Text += ((System.Windows.Forms.ButtonBase)sender).Text;
        }

        private void Button_Ponto_Click(object sender, EventArgs e)
        {
            if (!Visor.Text.Contains("."))
            {
                if (Visor.Text == "")
                    Visor.Text = "0.";
                else
                    Visor.Text += ".";
            }
        }

        private void Button_Inverter_Click(object sender, EventArgs e)
        {
            double.TryParse(Visor.Text, out Num1);
            Num1 *= -1;
            Visor.Text = Num1.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CalculadoraClear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Visor.Text = string.Empty;
        }

        private void BackSpace_Button_Click(object sender, EventArgs e)
        {
            string visor = Visor.Text;

            visor = visor.Remove(visor.Length - 1);

            Visor.Text = visor;
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
                            double.TryParse(Visor.Text, out Num2);
                            VisorAux.Text += $"{Num2} =";
                            resultado = Calculos.Soma(Num1, Num2);
                        }
                        else
                        {
                            resultado += Num2;
                            VisorAux.Text = $"{resultado - Num2} + {Num2} =";
                        }
                    }                   

                    Visor.Text = resultado.ToString();
                    ControleContinuidade = false;
                    break;

                case "Subtracao":
                    if (Visor.Text != "")
                    {
                        if (ControleContinuidade == true)
                        {
                            double.TryParse(Visor.Text, out Num2);
                            VisorAux.Text += $"{Num2} =";
                            resultado = Calculos.Subtracao(Num1, Num2);
                        }
                        else
                        {
                            resultado -= Num2;
                            VisorAux.Text = $"{resultado + Num2} - {Num2} =";
                        }
                    }                   

                    Visor.Text = resultado.ToString();
                    ControleContinuidade = false;
                    break;

                case "Multiplicacao":
                    if (Visor.Text != "")
                    {
                        if (ControleContinuidade == true)
                        {
                            double.TryParse(Visor.Text, out Num2);
                            VisorAux.Text += $"{Num2} =";
                            resultado = Calculos.Multiplicacao(Num1, Num2);
                        }
                        else
                        {
                            resultado *= Num2;
                            VisorAux.Text = $"{resultado / Num2} x {Num2} =";
                        }
                    }

                    Visor.Text = resultado.ToString();
                    ControleContinuidade = false;
                    break;

                case "Divisao":
                    if (Visor.Text != "")
                    {
                        if (ControleContinuidade == true)
                        {
                            double.TryParse(Visor.Text, out Num2);
                            VisorAux.Text += $"{Num2} =";
                            resultado = Calculos.Divisao(Num1, Num2);
                        }
                        else
                        {
                            resultado /= Num2;
                            VisorAux.Text = $"{resultado * Num2} ÷ {Num2} =";
                        }
                    }

                    Visor.Text = resultado.ToString();
                    ControleContinuidade = false;
                    break;

                case "Porcento":
                    double porcento = Calculos.Porcentagem(Num1, Num2);

                    if (OperacaoControle == "+")
                    {
                        resultado = Num1 + porcento;
                        Visor.Text = resultado.ToString();
                        VisorAux.Text += $"{porcento} =";
                    }
                    else if (OperacaoControle == "-")
                    {
                        resultado = Num1 - porcento;
                        Visor.Text = resultado.ToString();
                        VisorAux.Text += $"{porcento} =";
                    }
                    ControleContinuidade = false;
                    break;

                case "Elevado":
                    Visor.Text = Calculos.Quadrado(Num1).ToString();
                    ControleContinuidade = false;
                    break;

                case "Raiz":
                    if(Num1 == 0)
                    {
                        return;
                    }

                    Visor.Text = Calculos.Raiz_Quadrada(Num1).ToString();
                    ControleContinuidade = false;
                    break;
            }
        }

        private void Button_Soma_Click(object sender, EventArgs e)
        {
            Operacao("Soma", string.Empty, "+");
            OperacaoControle = "+";
        }

        private void Button_Subtracao_Click(object sender, EventArgs e)
        {
            Operacao("Subtracao", string.Empty, "-");
            OperacaoControle = "-";
        }

        private void Button_Multiplicacao_Click(object sender, EventArgs e)
        {
            Operacao("Multiplicacao", string.Empty, "X");
        }

        private void Button_Divisao_Click(object sender, EventArgs e)
        {
            Operacao("Divisao", string.Empty, "÷");
        }

        private void Button_Elevado_Click(object sender, EventArgs e)
        {
            Operacao("Elevado", "sqrt", string.Empty);
            Button_Resultado_Click_1(null, null);
        }

        private void Button_Porcento_Click(object sender, EventArgs e)
        {
            Operacao("Porcento", string.Empty, string.Empty);
            Button_Resultado_Click_1(null, null);
        }

        private void Button_Raiz_Click(object sender, EventArgs e)
        {
            Operacao("Raiz", "√", string.Empty);
            Button_Resultado_Click_1(null, null);
        }

        protected void CalculadoraClear()
        {
            Visor.Text = "";
            VisorAux.Text = "";
            Num1 = 0;
            Num2 = 0;
        }

        protected void Operacao(string opStatus, string simboloEsquerda, string simboloDireita)
        {
            if (Visor.Text != "")
            {
                if (opStatus != "Porcento")
                {
                    double.TryParse(Visor.Text, out Num1);

                    if (string.IsNullOrEmpty(simboloEsquerda))
                    {
                        VisorAux.Text = $"{Num1} {simboloDireita} ";
                    }
                    else
                    {
                        VisorAux.Text = $"{simboloEsquerda}({Num1})";
                    }
                }
                else
                {
                    double.TryParse(Visor.Text, out Num2);
                }
            }

            OperacaoStatus = opStatus;
            Visor.Text = "";
            ControleContinuidade = true;
        }
    }
}
