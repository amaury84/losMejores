using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace losMejores
{
    public class EmpleadoFijo : Empleado
    {
        private double salarioFijo;
        public EmpleadoFijo(string nombre, double salarioFijo) : base(nombre) { this.salarioFijo = salarioFijo; }
        public override double CalcularSalario() => salarioFijo;
    }
}
