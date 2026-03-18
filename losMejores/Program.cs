using System;

class Program{
    static void Main(){
        Console.WriteLine("Nuevo");
        //nuevo comentario
        Contador contador = new Contador();
        var cuenta= contador.Incrementar();
        Console.WriteLine(cuenta);
    }
}
