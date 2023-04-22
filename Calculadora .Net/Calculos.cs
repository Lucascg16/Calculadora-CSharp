using System;

namespace Calculadora.Net
{
    /// <summary>
    /// Biblioteca Auxiliar de calculos para a calculadora
    /// </summary>
    public class Calculos
    {
        /// <summary>
        /// Calcula a soma entre dois numeros
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Soma(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Calcula a subtracao entre dois numeros
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Subtracao(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// Calcula a multiplicacao entre dois numeros
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Multiplicacao(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Calcula a divisao entre dois numeros
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Divisao(double x, double y)
        {
            return (x / y);
        }

        /// <summary>
        /// Eleva um numero ao quadrado
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Quadrado(double x)
        {
            return Math.Pow(x, 2);
        }

        /// <summary>
        /// Calcula a raiz quadradoa do numero
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Raiz_Quadrada(double x)
        {
            return Math.Sqrt(x);
        }

        /// <summary>
        /// Calcula a porcentagem entre 2 numeros
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Porcentagem(double x)
        {
            return x / 100;
        }
    }
}
