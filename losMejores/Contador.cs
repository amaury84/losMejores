using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Contador
{
    private int valor = 0;
    public int Incrementar() { valor++; return valor; }
    public int Decrementar() { valor--; return valor; }
}
