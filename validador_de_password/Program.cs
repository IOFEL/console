using System;
using System.Text.RegularExpressions;

namespace validador_de_password
{
    class Program
    {
        static void Main(string[] args)
        {
            var validador = new Validador();
            
            Console.WriteLine("Ingrese su password:");

            var password = Console.ReadLine();

            var resultado = validador.Validar(password) ? "valida" : "invalida";
            
            Console.WriteLine($"Resultado: password {resultado}");
            
        }
    }


    class Validador
    {
        public Boolean Longitud(string password)
        {
            return password.Length >= 8 && password.Length <= 60;
        }

        public Boolean TieneNumeros(string password)
        {
            return new Regex(@"[0-9]+").IsMatch(password);
        }

        public Boolean Validar(string password)
        {
            return Longitud(password) && TieneNumeros(password);
        }
        
    }
}