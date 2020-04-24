using System;

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
        public Boolean Validar(string password)
        {
            return password.Length >= 8 && password.Length <= 60;
        }
    }
}