using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practica120822
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {   
        //Suma
        [WebMethod(Description = "Sumar dos numeros")]
        public double Suma(double sumando1, double sumando2)
        {
            return sumando1 + sumando2;
        }
        // Resta
        [WebMethod(Description = "Restar dos numeros")]
        public double Resta(double minuendo, double sustraendo)
        {
            return minuendo - sustraendo;
        }
        // Multiplicacion
        [WebMethod(Description = "Multiplicar dos numeros")]
        public double Multiplicar(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }
        // Division
        [WebMethod(Description = "Dividir dos numeros")]
        public double Dividir(double Dividendo, double Divisor)
        {
            return Dividendo / Divisor;
        }
        // Potencia
        [WebMethod(Description = "Potencia")]
        public double Potencia(double Base, double Exponente)
        {
            return Math.Pow(Base, Exponente);
        }
        // Raiz
        [WebMethod(Description = "Radicacion")]
        public double Radicacion(double Radicando)
        {
            return Math.Sqrt(Radicando);
        }
        // Porcentaje
        [WebMethod(Description = "Porcentaje")]
        public double Porcentaje(double nro1)
        {
            return (nro1/100);
        }
        // Factorial
        private double factorial(int n)
        {
            if (n == 0) return 1;
            else return n * factorial(n - 1);
        }
        [WebMethod(Description = "Factorial")]
        public double fact(int numero)
        {
            return factorial(numero);
        }
        // Seno
        [WebMethod(Description = "Seno")]
        public double Seno(int numero)
        {
            return Math.Sin(numero);
        }
        // Coseno
        [WebMethod(Description = "Coseno")]
        public double Coseno(int numero)
        {
            return Math.Cos(numero);
        }
    }
}
