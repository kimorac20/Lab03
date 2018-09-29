using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Credito:Cuenta
    {
        public Credito(decimal saldo, List<string> registro)
            : base(saldo, registro)
        {
        }

    }
}
