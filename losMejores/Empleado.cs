using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Empleado
    {
        public string Nombre { get; set; }
        public Empleado(string nombre) { Nombre = nombre; }
        public virtual double CalcularSalario() => 0;
    }

