using System;
using System.Collections.Generic;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Credito cr = new Credito(0, new List<string>() { "Creación" });

            Debito db = new Debito(10000, new List<string>() { "Creación" });


            Console.WriteLine("Digite el monto a debitar");

            decimal x = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tipo de cuenta: \n1. Debito \n2. Credito.");

            int a = int.Parse(Console.ReadLine());

            Cuenta cuenta = null;
            switch (a)
            {
                case 1:
                    cuenta = db;
                    break;
                case 2:
                    cuenta = cr;
                    break;

                default:
                    break;
            }

            cuenta.Vender(x, a);

            foreach (string r in cuenta.Registro)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("Saldo actual:" + cuenta.Saldo);


            Console.ReadLine();
            
        }
    }
}
