using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza a SOMA de dois numeros em 'double'
        /// </summary>
        /// <param name="x">Um numero para soma em 'double'</param>
        /// <param name="y">O segundo numero para soma em 'double'</param>
        public void Somar(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");;
        }
        public void Multiplicar(double x, double y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");;
        }
        public void Dividir(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {Math.Round (x / y, 2)}");
        }
        public void Potencia(double x, double y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round (seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round (coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round (tangente, 4)}");
        }       

    }
}