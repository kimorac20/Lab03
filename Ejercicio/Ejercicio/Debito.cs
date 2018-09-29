using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Debito : Cuenta
    {

        public Debito(decimal saldo, List<string> registro)
            : base(saldo, registro)
        {
        }

        public override void Vender(decimal m, int t)
        {
            if (Saldo - m > 0) {
                Saldo = Saldo - m;
                Registro.Add("El retiro fue realizado con éxito.");
            }
            else
            {
                Registro.Add("Su cuenta no tiene suficiente saldo.");
            }
        }


    }
}
