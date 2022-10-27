using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej1_Operaciones
{
    internal class Sumar: Operacion
    {
        public int operar (int v1, int v2)
        {
            Valor1 = v1;
            Valor2 = v2;

            return Resultado = Valor1 + Valor2;
        }
    }
}