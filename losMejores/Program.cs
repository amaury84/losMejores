using System;

class Program{
    static void Main(){
        Console.WriteLine("Nuevo");
        Contador contador = new Contador();
        var cuenta= contador.Incrementar();
        Console.WriteLine(cuenta);
    }
}