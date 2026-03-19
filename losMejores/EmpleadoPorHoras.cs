using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace losMejores
{
    public class EmpleadoPorHoras : Empleado
    {
        private int horas;
        private double valorHora;
        public EmpleadoPorHoras(string nombre, int horas, double valorHora) : base(nombre)
        { this.horas = horas; this.valorHora = valorHora; }
        public override double CalcularSalario() => horas * valorHora;
    }
}
