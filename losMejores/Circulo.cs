using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace losMejores
{
    public class Circulo : Figura
    {
        private double radio;
        public Circulo(double radio) { this.radio = radio; }
        public override double CalcularArea() => Math.PI * radio * radio;
    }
}
