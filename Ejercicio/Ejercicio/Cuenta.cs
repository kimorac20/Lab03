using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Cuenta
    {
        public decimal Saldo { get; set; }
        public List<string> Registro { get; set; }

        public Cuenta(decimal saldo, List<string> registro)
        {
            Saldo = saldo;
            Registro = registro;
        }

        public virtual void Vender(decimal m, int t)
        {
            Saldo = Saldo - m;
            Registro.Add("El retiro fue realizado con éxito.");
        }
    }
}
