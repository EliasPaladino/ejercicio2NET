using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Circulo : FiguraGeometrica
    {

        public double Radio {  get; set; }
        public override double calcularArea()
        {
            return Math.PI * Math.Pow(this.Radio, 2);
        }

        public override double calcularPerimetro()
        {
            return Math.PI * 2 * this.Radio;
        }
    }
}
