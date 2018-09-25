using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Credito cr = new Credito()
            {
                Saldo = 0,
                Registro = new string[] { "Creación" }
            };

            Debito db = new Debito()
            {
                Saldo = 10000,
                Registro = new string[] { "Creación" }
            };


            Console.WriteLine("Digite el monto a debitar");

            decimal x = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tipo de cuenta: \n1. Debito \n2. Credito.");

            int a = int.Parse(Console.ReadLine());

            Cuenta cuenta = new Cuenta();

            cuenta.Vender(x, a);

            Console.ReadLine();
            
        }
    }
}
