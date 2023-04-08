using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Net
{
    public class Calculos
    {
        public static double Soma(double x, double y)
        {
            return x + y;
        }
        public static double Subtracao(double x, double y)
        {
            return x - y;
        }
        public static double Multiplicacao(double x, double y)
        {
            return x * y;
        }
        public static double Divisao(double x, double y)
        {
            return (x / y);
        }
        public static double Quadrado(double x)
        {
            return Math.Pow(x, 2);
        }
        public static double Raiz_Quadrada(double x)
        {
            return Math.Pow(x, 1 / 2);
        }
        public static double Porcentagem(double x, double y)
        {
            return (x * y) / 100;
        }
    }
}
