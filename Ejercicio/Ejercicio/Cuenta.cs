using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Cuenta
    {
        public decimal Saldo { get; set; }
        public string[] Registro { get; set; }

        
        public virtual void Vender(decimal m, int t)
        {

            switch (t)
            {
                case 1:
                    
                    break;
                case 2:
                    break;

                default:
                    break;
            }
        }
    }
}
