using System;
class Programa
{
    static void Main(string[] args)
    {
        //tipo mais comum em relação a números com , 
        double salario = 3000.15;
        Console.WriteLine(salario);

        //short armazena até 16 bits (2^16) = 16000
        short y = 15000;
        Console.WriteLine(y);

        //int armazena até 32 bits (2^32) = 200.000.000.000
        int salarioInteiro = (int)salario; //parseando
        Console.WriteLine(salarioInteiro);

        //long armazena 64 bits (2^64) = 2.000.000.000.000.000.000
        long x = 200000000000000000;
        Console.WriteLine(x);

        //outro tipo de double
        float altura = 1.62f; //sufixo f para avisar que queremos utilizar float
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}