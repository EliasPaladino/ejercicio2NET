using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Rectangulo : FiguraGeometrica
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }
        public override double calcularArea()
        {
            return Lado1 * Lado2;
        }

        public override double calcularPerimetro()
        {
            return 2*Lado1 + 2*Lado2;
        }
    }
}
