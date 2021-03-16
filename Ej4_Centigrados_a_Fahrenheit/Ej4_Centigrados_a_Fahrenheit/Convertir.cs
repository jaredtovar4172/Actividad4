using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_Centigrados_a_Fahrenheit
{
    class Convertir
    {
        public double Temperatura (double c)
        {
            double f = (c * 9 / 5) + 32;
            return (f);
        }
    }
}
