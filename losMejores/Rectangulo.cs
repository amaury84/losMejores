using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class Rectangulo : Figura
    {
        private double @base, altura;
        public Rectangulo(double @base, double altura) { this.@base = @base; this.altura = altura; }
        public override double CalcularArea() => @base * altura;
    }

